using Electro_Tickets.Models;
using Microsoft.EntityFrameworkCore;

namespace Electro_Tickets.Data;

public class AppDbInitializer
{
  public static void Seed(IApplicationBuilder app)
  {
    using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
    var context = serviceScope?.ServiceProvider.GetRequiredService<AppDbContext>();
    context?.Database.Migrate();
    context?.Database.EnsureCreated();

    //cinema
    if (!(!context?.Cinemas.Any() ?? false)) return;
    context.Cinemas.AddRange(new List<Cinema>()
    {
      new Cinema()
      {
        Name = "Cinema 1",
        Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
        Description = "This is the description of the first cinema"
      },
      new Cinema()
      {
        Name = "Cinema 2",
        Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
        Description = "This is the description of the first cinema"
      },
      new Cinema()
      {
        Name = "Cinema 3",
        Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
        Description = "This is the description of the first cinema"
      },
      new Cinema()
      {
        Name = "Cinema 4",
        Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
        Description = "This is the description of the first cinema"
      },
      new Cinema()
      {
        Name = "Cinema 5",
        Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
        Description = "This is the description of the first cinema"
      },
    });
    context.SaveChanges();
    //actors
    if (!(!context?.Actors.Any() ?? false)) return;
    context.Actors.AddRange(new List<Actor>()
    {
      new Actor()
      {
        FullName = "Actor 1",
        Bio = "This is the Bio of the first actor",
        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
      },
      new Actor()
      {
        FullName = "Actor 2",
        Bio = "This is the Bio of the second actor",
        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
      },
      new Actor()
      {
        FullName = "Actor 3",
        Bio = "This is the Bio of the second actor",
        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
      },
      new Actor()
      {
        FullName = "Actor 4",
        Bio = "This is the Bio of the second actor",
        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
      },
      new Actor()
      {
        FullName = "Actor 5",
        Bio = "This is the Bio of the second actor",
        ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
      }
    });
    context.SaveChanges();
    //movies
    if (!(!context?.Movies.Any() ?? false)) return;
    context.Movies.AddRange(new List<Movie>()
    {
      new Movie()
      {
        Name = "Life",
        Description = "This is the Life movie description",
        Price = 39.50,
        ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
        StartDate = DateTimeOffset.Now.AddDays(-10),
        EndDate = DateTimeOffset.Now.AddDays(10),
        CinemaId = 3,
        ProducerId = 3,
        MovieCategory = MovieCategory.Documentary
      },
      new Movie()
      {
        Name = "The Shawshank Redemption",
        Description = "This is the Shawshank Redemption description",
        Price = 29.50,
        ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
        StartDate = DateTime.Now,
        EndDate = DateTime.Now.AddDays(3),
        CinemaId = 1,
        ProducerId = 1,
        MovieCategory = MovieCategory.Action
      },
      new Movie()
      {
        Name = "Ghost",
        Description = "This is the Ghost movie description",
        Price = 39.50,
        ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
        StartDate = DateTime.Now,
        EndDate = DateTime.Now.AddDays(7),
        CinemaId = 4,
        ProducerId = 4,
        MovieCategory = MovieCategory.Horror
      },
      new Movie()
      {
        Name = "Race",
        Description = "This is the Race movie description",
        Price = 39.50,
        ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
        StartDate = DateTime.Now.AddDays(-10),
        EndDate = DateTime.Now.AddDays(-5),
        CinemaId = 1,
        ProducerId = 2,
        MovieCategory = MovieCategory.Documentary
      },
      new Movie()
      {
        Name = "Scoob",
        Description = "This is the Scoob movie description",
        Price = 39.50,
        ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
        StartDate = DateTime.Now.AddDays(-10),
        EndDate = DateTime.Now.AddDays(-2),
        CinemaId = 1,
        ProducerId = 3,
        MovieCategory = MovieCategory.Cartoon
      },
      new Movie()
      {
        Name = "Cold Soles",
        Description = "This is the Cold Soles movie description",
        Price = 39.50,
        ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
        StartDate = DateTime.Now.AddDays(3),
        EndDate = DateTime.Now.AddDays(20),
        CinemaId = 1,
        ProducerId = 5,
        MovieCategory = MovieCategory.Drama
      }
    });

    context.SaveChanges();


    //Actors & Movies
    if (!(!context?.Actors_and_Movies.Any() ?? false)) return;
    context.Actors_and_Movies.AddRange(new List<Actors_Movies>()
    {
      new Actors_Movies()
      {
        ActorId = 1,
        MovieId = 1
      },
      new Actors_Movies()
      {
        ActorId = 3,
        MovieId = 1
      },

      new Actors_Movies()
      {
        ActorId = 1,
        MovieId = 2
      },
      new Actors_Movies()
      {
        ActorId = 4,
        MovieId = 2
      },

      new Actors_Movies()
      {
        ActorId = 1,
        MovieId = 3
      },
      new Actors_Movies()
      {
        ActorId = 2,
        MovieId = 3
      },
      new Actors_Movies()
      {
        ActorId = 5,
        MovieId = 3
      },


      new Actors_Movies()
      {
        ActorId = 2,
        MovieId = 4
      },
      new Actors_Movies()
      {
        ActorId = 3,
        MovieId = 4
      },
      new Actors_Movies()
      {
        ActorId = 4,
        MovieId = 4
      },


      new Actors_Movies()
      {
        ActorId = 2,
        MovieId = 5
      },
      new Actors_Movies()
      {
        ActorId = 3,
        MovieId = 5
      },
      new Actors_Movies()
      {
        ActorId = 4,
        MovieId = 5
      },
      new Actors_Movies()
      {
        ActorId = 5,
        MovieId = 5
      },


      new Actors_Movies()
      {
        ActorId = 3,
        MovieId = 6
      },
      new Actors_Movies()
      {
        ActorId = 4,
        MovieId = 6
      },
      new Actors_Movies()
      {
        ActorId = 5,
        MovieId = 6
      },
    });
    context.SaveChanges();
  }
}

public class Cinemas
{
  // Create a list of cinema objects
  List<Cinema> cinemas = new List<Cinema>()
  {
    new Cinema()
    {
      Name = "Cinema 1",
      Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
      Description = "This is the description of the first cinema"
    },
    new Cinema()
    {
      Name = "Cinema 2",
      Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
      Description = "This is the description of the first cinema"
    },
    new Cinema()
    {
      Name = "Cinema 3",
      Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
      Description = "This is the description of the first cinema"
    },
    new Cinema()
    {
      Name = "Cinema 4",
      Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
      Description = "This is the description of the first cinema"
    },
    new Cinema()
    {
      Name = "Cinema 5",
      Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
      Description = "This is the description of the first cinema"
    },
  };


}
