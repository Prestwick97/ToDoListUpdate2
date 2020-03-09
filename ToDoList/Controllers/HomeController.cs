using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      Item starterItem = new Item("Add First Item to To Do List");
      return View(starterItem);
    }
    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return View("Index", myItem);
    }

  }
}