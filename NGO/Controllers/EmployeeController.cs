using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NGO.DB;
using NGO.Models;
using NGO.Repo;
namespace NGO.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View(EmployeeRepo.Get());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var Employee = EmployeeRepo.Get(id);
            return View(Employee);
        }

     

      
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var db = new FoodWasteEntities();

            db.Employees.Remove(db.Employees.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

