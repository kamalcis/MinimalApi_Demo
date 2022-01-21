using MinimalApi_Demo.Models;

namespace MinimalApi_Demo.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {
            new()
            {
                Id = 1,
                Title = "Avator",
                Description = "This is a famous animation movie. A scientist was doing a research on" +
                               " creating real human. Avator created from there and ran out",
                Rating = 4.5
            },

            new()
            {
                Id = 2,
                Title = "Jungle Book",
                Description = "This is a cartoon animation film, This movie shows how a human child" +
                               " survive in the jungle with the help of other animals",
                Rating = 4.0
            },
            new()
            {
                Id = 3,
                Title = "The Good, Bad and Ugly",
                Description = "This movie describes the characteristics of" +
                               " the three types of man by different individual",
                Rating = 3.5
            },
            new()
            {
                Id = 4,
                Title = "Bermuda Triangle",
                Description = "This is a horror movie" +
                               " This movie shows how people are lost in the deep sea one by one",
                Rating = 5.0
            }

        };
    }
}
