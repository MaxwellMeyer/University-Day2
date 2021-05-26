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
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Dept dept)
    {
      _db.Depts.Add(dept);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisDept = _db.Depts
        .Include(dept => dept.JoinEntities)
        .ThenInclude(join => join.Student)
        .FirstOrDefault(dept => dept.DeptId == id);
      return View(thisDept);
    }

    // public ActionResult Edit(int id)
    // {
    //   var thisDept = _db.Depts.FirstOrDefault(dept => dept.DeptId == id);
    //   return View(thisDept);
    // }

    // [HttpPost]
    // public ActionResult Edit(Dept dept)
    // {
    //   _db.Entry(dept).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisDept = _db.Depts.FirstOrDefault(dept => dept.DeptId == id);
    //   return View(thisDept);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisDept = _db.Depts.FirstOrDefault(dept => dept.DeptId == id);
    //   _db.Depts.Remove(thisDept);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}
