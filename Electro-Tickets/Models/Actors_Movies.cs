namespace Electro_Tickets.Models;

public class Actors_Movies
{

  public int MovieId { get; set; }
  public Movie Movie { get; set; }
  public int ActorId { get; set; }
  public Actor Actor { get; set; }
  public Actors_Movies()
  {
  }
}
