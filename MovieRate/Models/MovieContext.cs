using Microsoft.EntityFrameworkCore;

namespace MovieRate
{
    // Чтобы подключиться к базе данных через Entity Framework, необходим контекст данных. 
    // Контекст данных представляет собой класс, производный от класса DbContext.
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public MovieContext(DbContextOptions<MovieContext> options)
           : base(options)
        {
            if (Database.EnsureCreated())
            {
                Movies?.Add(new Movie 
                { 
                    Title = "Stalker", 
                    Director = "Andrei Tarkovsky", 
                    Genre = "Drama, Sci-Fi", 
                    Release = "1979", 
                    Poster = new Uri("https://m.media-amazon.com/images/M/MV5BYTAzZmEzZjEtNmIzMS00MzlhLWE0Y2ItNDRlNTQwN2E0MDE4XkEyXkFqcGdeQXVyMzY0MTE3NzU@._V1_SX300.jpg"), 
                    Description = "A guide leads two men through an area known as the Zone to find a room that grants wishes." 
                });

                Movies?.Add(new Movie
                {
                    Title = "House of Sand and Fog",
                    Director = "Vadim Perelman",
                    Genre = "Crime, Drama",
                    Release = "2004",
                    Poster = new Uri("https://m.media-amazon.com/images/M/MV5BMTIzMjQ5NzM2M15BMl5BanBnXkFtZTYwMzU2NDY3._V1_SX300.jpg"),
                    Description = "An abandoned wife is evicted from her house and starts a tragic conflict with her house's new owners."
                });

                Movies?.Add(new Movie
                {
                    Title = "Forrest Gump",
                    Director = "Robert Zemeckis",
                    Genre = "Drama, Romance",
                    Release = "1994",
                    Poster = new Uri("https://m.media-amazon.com/images/M/MV5BNWIwODRlZTUtY2U3ZS00Yzg1LWJhNzYtMmZiYmEyNmU1NjMzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"),
                    Description = "The history of the United States from the 1950s to the '70s unfolds from the perspective of an Alabama man with an IQ of 75, who yearns to be reunited with his childhood sweetheart."
                });

                Movies?.Add(new Movie
                {
                    Title = "Schindler's List",
                    Director = "Steven Spielberg",
                    Genre = "Biography, Drama, History",
                    Release = "1993",
                    Poster = new Uri("https://m.media-amazon.com/images/M/MV5BNDE4OTMxMTctNmRhYy00NWE2LTg3YzItYTk3M2UwOTU5Njg4XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg"),
                    Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis."
                });

                Movies?.Add(new Movie
                {
                    Title = "The Shawshank Redemption",
                    Director = "Frank Darabont",
                    Genre = "Drama",
                    Release = "1994",
                    Poster = new Uri("https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_SX300.jpg"),
                    Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."
                });


                SaveChanges();
            }
        }
    }
}