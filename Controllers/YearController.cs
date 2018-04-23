using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Year.Models;

namespace Year.Controllers
{
  public class YearController : Controller
  {

    [HttpGet("/Year")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/Year/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/Year")]
    public ActionResult Create()
    {
      Item newYear = new Item (Request.Form["new-Year"]);
      newYear.Save();
      List<Item> allYear = Item.GetAll();
      return View("Index", allItems);
    }

    [HttpPost("/Year/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

  }
}
