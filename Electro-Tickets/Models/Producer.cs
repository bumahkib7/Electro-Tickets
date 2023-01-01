using System.ComponentModel.DataAnnotations;

namespace Electro_Tickets.Models;

public class Producer
{
  [Key]
  public int ProducerID { get; set; }

  public string ProfilePictureURL { get; set; }

  public string FullName { get; set; }

  public String Bio { get; set; }

  //RelashionShips
  public List<Movie> Movies { get; set; }

  public Producer()
  {
  }

}
