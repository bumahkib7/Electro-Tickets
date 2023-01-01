using Electro_Tickets.Data;
using Electro_Tickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace Electro_Tickets.Controllers;

public class ActorsController : Controller
{
  private readonly AppDbContext _dbContext;

  public ActorsController(AppDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public IActionResult Index()
  {
    var data = _dbContext.Actors.ToList();
    Console.WriteLine(data);
    return View(data);
  }

  public IActionResult Edit(int id)
  {
    // Retrieve the actor from the database
    var actor = _dbContext.Actors.Find(id);

    // Pass the actor to the view
    return View(actor);
  }

  public IActionResult Details(int id)
  {
    // Retrieve the actor from the database
    var actor = _dbContext.Actors.Find(id);

    // Pass the actor to the view
    return View(actor);
  }

  public IActionResult Delete(int id)
  {
    // Retrieve the actor from the database
    var actor = _dbContext.Actors.Find(id);

    // Pass the actor to the view
    return View(actor);
  }

  [HttpPost]
  public IActionResult Edit(Actor actor)
  {
    // Update the actor's information in the database
    _dbContext.Actors.Update(actor);
    _dbContext.SaveChanges();

    // Redirect to the list of actors
    return RedirectToAction("Index");
  }

  [HttpPost]
  public IActionResult Delete(Actor actor)
  {
    // Delete the actor from the database
    _dbContext.Actors.Remove(actor);
    _dbContext.SaveChanges();

    // Redirect to the list of actors
    return RedirectToAction("Index");
  }







}
