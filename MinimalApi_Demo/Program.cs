using MinimalApi_Demo.Models;
using MinimalApi_Demo.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IMovieService, MovieService>();

var app = builder.Build();
app.UseSwagger();

app.MapGet("/", () => "Hello World!");


app.MapPost("/create", (Movie movie, IMovieService service) => Create(movie, service));
IResult Create(Movie movie, IMovieService service)
{
    var result = service.Create(movie);
    return Results.Ok(result);
}

app.MapGet("/get", (int id, IMovieService service) => Get(id, service));
IResult Get(int id, IMovieService service)
{
    var movie = service.Get(id);
    if (movie is null) { return Results.NotFound("Movie Not found"); }
    return Results.Ok(movie);
}

app.MapPut("/update", (Movie movie, IMovieService service) => Update(movie, service));
IResult Update(Movie movie, IMovieService service)
{
    var updatedMovie = service.Update(movie);
    if(updatedMovie is null) { return Results.NotFound("No movie found with the id"); }
    return Results.Ok(updatedMovie);
}

app.MapDelete("/delete", (int id, IMovieService service) => Delete(id, service));
IResult Delete(int id, IMovieService service)
{
    var result = service.Delete(id);
    return Results.Ok(result);
}

app.MapGet("/getall", (IMovieService service) => GetAll(service));
IResult GetAll( IMovieService service)
{
    var result = service.GetAll();
    return Results.Ok(result);
}


app.UseSwaggerUI();
app.Run();
