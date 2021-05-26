using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using System.Linq;

namespace University.Controllers
{
  public class DeptsController : Controller
  {
    private readonly UniversityContext _db;

    public DeptsController(UniversityContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Dept> model = _db.Depts.ToList();
      return View(model);
    }
  }
}
