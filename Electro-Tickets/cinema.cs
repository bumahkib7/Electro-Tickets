using System.Collections;
using System.Globalization;
using CsvHelper;
using Electro_Tickets.Models;

namespace Electro_Tickets;

public class cinema
{
  protected virtual void Main(string[] args)
  {
// Create a list of cinema objects
    var cinemas = new List<Cinema>
    {
      new()
      {
        Name = "Cinema 1",
        Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
        Description = "This is the description of the first cinema"
      },
      new()
      {
        Name = "Cinema 2",
        Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
        Description = "This is the description of the first cinema"
      },
      new()
      {
        Name = "Cinema 3",
        Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
        Description = "This is the description of the first cinema"
      },
      new()
      {
        Name = "Cinema 4",
        Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
        Description = "This is the description of the first cinema"
      },
      new()
      {
        Name = "Cinema 5",
        Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
        Description = "This is the description of the first cinema"
      }
    };

// Write the data to a CSV file
    using var writer = new StreamWriter("cinemas.csv");
    using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
    csv.WriteRecords((IEnumerable)cinemas);
  }
}
