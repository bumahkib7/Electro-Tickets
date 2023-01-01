using System.ComponentModel.DataAnnotations;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using Electro_Tickets.Data;
using Microsoft.EntityFrameworkCore;

namespace Electro_Tickets.Models;

public class Actor
{
  [Key] public int Id { get; set; }


  [Display(Name = "ProfilePicture")] public string ProfilePictureURL { get; set; }

  [Display(Name = "Full Name")] public string FullName { get; set; }

  [Display(Name = "Biography")] public string Bio { get; set; }

  public List<Actors_Movies> Actors_Movies { get; set; }
}

public sealed class ActorMap : ClassMap<Actor>
{
  public ActorMap()
  {
    Map(m => m.FullName).Name("FullName");
    Map(m => m.Bio).Name("Bio");
    Map(m => m.ProfilePictureURL).Name("ProfilePictureURL");
  }


// In your ASP.NET code, you can use the following method to import the data from the CSV file into the database
  public void ImportActorsFromCsv(string filePath)
  {
    // Read the data from the CSV file
    using (var reader = new StreamReader(filePath))
    using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
    {
      // Map the CSV fields to the actor model properties
      csv.Context.RegisterClassMap<ActorMap>();

      // Read the records from the CSV file
      var actors = csv.GetRecords<Actor>();

      // Insert the records into the database
      using (var context = new AppDbContext(
               options: new DbContextOptions<AppDbContext>()
               ))
      {
        context.Actors.AddRange(actors);
        context.SaveChanges();
      }
    }
  }
}
