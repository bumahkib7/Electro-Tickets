using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Electro_Tickets.Models;

public class Movie
{
  [Key]
  public int MovieId{ get; set; }

  public string Name { get; set; }

  public string Description { get; set; }

  public double Price { get; set; }

  public string ImageURL { get; set; }

  public DateTimeOffset StartDate { get; set; }

  public DateTimeOffset EndDate { get; set; }

  public MovieCategory MovieCategory { get; set; }
  public List<Actors_Movies> Actors_Movies{ get; set; }
  //Cinema
  public int CinemaId { get; set; }
  [ForeignKey("CinemaId")]
  public Cinema Cinema { get; set; }

  //Producer
  public int ProducerId { get; set; }
  [ForeignKey("ProducerId ")]
  public Producer Producer { get; set; }
  public Movie()
  {
  }
}

public enum MovieCategory
{
  Action = 1,
  Comedy,
  Drama,
  Documentary,
  Horror,
  Cartoon,
  Thriller,
  SciFi,
  Fantasy,

}
