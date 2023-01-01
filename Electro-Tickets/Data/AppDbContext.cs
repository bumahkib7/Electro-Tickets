using Electro_Tickets.Models;
using Microsoft.EntityFrameworkCore;

namespace Electro_Tickets.Data;

public class AppDbContext : DbContext
{

  public AppDbContext(DbContextOptions<AppDbContext>
    options, DbSet<Actor> actors,
    DbSet<Cinema> cinemas,
    DbSet<Producer> producers,
    DbSet<Movie> movies,
    DbSet<Actors_Movies> actorsAndMovies) : base(options)
  {

  }

  public AppDbContext(DbContextOptions<AppDbContext>
    options): base(options)
  {

  }


  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Actors_Movies>().HasKey(am => new
    {
      am.ActorId,
      am.MovieId
    });

    modelBuilder.Entity<Actors_Movies>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
    modelBuilder.Entity<Actors_Movies>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);
    base.OnModelCreating(modelBuilder);
  }

  public DbSet<Actor> Actors { get; set; } = null!;
  public DbSet<Cinema> Cinemas { get; set; } = null!;
  public DbSet<Producer> Producers{ get; set; } = null!;
  public DbSet<Movie> Movies { get; set; } = null!;
  public DbSet<Actors_Movies> Actors_and_Movies { get; set; } = null!;
}
