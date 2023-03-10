using System.ComponentModel.DataAnnotations;

namespace Electro_Tickets.Models;

public class Cinema
{
  [Key]
  public int CinemaId { get; set; }
  public string Logo { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public List<Movie> Movies { get; set; }
  public Cinema()
  {
  }
}
