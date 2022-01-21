using MinimalApi_Demo.Models;

namespace MinimalApi_Demo.Services
{
    public interface IMovieService
    {
        public Movie Get(int id);
        public Movie Create(Movie movie);
        public Movie Update(Movie movie);   
        public bool Delete(int id);
        public List<Movie> GetAll();


    }
}
