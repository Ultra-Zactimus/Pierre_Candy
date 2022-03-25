using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Candyman.Models;
using System.Collections.Generic;
using System.Linq;

namespace Candyman.Controllers
{
  public class FlavorsControllers : Controller
  {
    private readonly CandymanContext _db;
    public FlavorsControllers(CandymanContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor)
    {
      _db.Flavors.Add(flavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    
  }
}