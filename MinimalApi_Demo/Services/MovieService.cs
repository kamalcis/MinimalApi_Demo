using MinimalApi_Demo.Models;
using MinimalApi_Demo.Repositories;

namespace MinimalApi_Demo.Services
{
    public class MovieService: IMovieService
    {
        public Movie Create(Movie movie)
        {
            movie.Id = MovieRepository.Movies.Count + 1;
            MovieRepository.Movies.Add(movie);
            return movie;
        }

        public Movie Get(int id)
        {
            Movie movie = MovieRepository.Movies.FirstOrDefault(x => x.Id == id);
            return movie;
        }

        public Movie Update(Movie newMovie)
        {
            Movie oldMovie = MovieRepository.Movies.FirstOrDefault(m=> m.Id == newMovie.Id);

            if(oldMovie is null) { return null; }

            oldMovie.Title = newMovie.Title;
            oldMovie.Description = newMovie.Description;
            oldMovie.Rating = newMovie.Rating;

            return newMovie;

        }

        public bool Delete(int id)
        {
            Movie movie = MovieRepository.Movies.FirstOrDefault(m=> m.Id == id);
            if(movie is null) { return false; }

            MovieRepository.Movies.Remove(movie);

            return true;

        }

        public List<Movie> GetAll()
        {
            return MovieRepository.Movies.ToList();
        }
    }
}
