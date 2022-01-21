About The Application:
This is a demo application that exposes movie services and user services (user services will be used in next part). 
This application exposes the API for CRUD operation on Movie Repository which is a static repository. Using this API 
application user can create, update, delete, read Movie information. 


Architecture:
This is just a sample application to demonstrate a Simple WebAPI architecture using .NET 6 (.NET Core). 

Class Hierarchy:
* Model folder contains Movie, User and UserLogin Model or Data classes.
* Repositories folder stores static data for Movie and User. (Repository can be changed to actual database connection)
* Services Folder Contain One Interface class and One Implementation Class for both Movie and User service. 


Registering the Services:
By default .net 6 support Dependency Injection which is used for loosely coupled architeture design. 
Inorder to access the Services from EndPoint the services have been registered with IOC Container in Program.cs file using following 
code----
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IMovieService, MovieService>();
During invoking the services the .NET framework automatically inject the object of the called service. 



Exposing the Endpoints:
Inorder to access those services from outside world end points have been created in Program.cs files using the following code

app.MapGet("/get", (int id, IMovieService service) => Get(id, service));
IResult Get(int id, IMovieService service)
{
    var movie = service.Get(id);
    if (movie is null) { return Results.NotFound("Movie Not found"); }
    return Results.Ok(movie);
}


Swagger Configuring:
Swagger playes important role in discovering and running the services in a smarter way instead of Postman.
Swashbuckle.AspNetCore 6.2.3 have been installed to enable the swagger functionality. 
A little bit of configuration need to be done as well in Program.cs file to enable it. 


Running or Invoking the services:
The following url will invoke the services. The port may need to be adjusted. 
https://localhost:7186/swagger/index.html 
All the API method should be visibale e.g create, get, update, delete, getall.
By supplying appropriate parameter value all the method should be executed. 









