using Electro_Tickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Electro_Tickets.Controllers
{
    public class MoviesController : Controller
    {
      private readonly AppDbContext _db;

      public MoviesController(AppDbContext db)
      {
        _db = db;
      }
        public async Task<IActionResult> Index()
        {
          var allMovies = await _db.Movies.ToListAsync();
            return View();
        }
    }
}
