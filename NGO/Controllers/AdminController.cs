using NGO.DB;
using NGO.Models;
using NGO.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGO.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View(AdminRepo.Get());

        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            var Admin = AdminRepo.Get(id);
            return View(Admin);
        }

        // GET: Admin/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(AdminModel Admin)
        {
            if (ModelState.IsValid) { 
            
                AdminRepo.Create(Admin);
                return RedirectToAction("Index");
            }
            return View(Admin);
        }
      

        [HttpGet]
        public ActionResult AddEmployee() {


            return View();
        
        }
     

        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel Employee) 
        {
        
          if (ModelState.IsValid)
            {
                EmployeeRepo.Create(Employee);
                return RedirectToAction("Index");

            }
          return View();
        
        
        }
        [HttpGet]
        public ActionResult AddResturant()
        {

            return View();
        
        }
        [HttpPost]
        public ActionResult AddResturantb(ResturantModel Resturant) 
        {

            if (ModelState.IsValid)
            {
                ResturantRepo.Create(Resturant);
                return RedirectToAction("Index");

            }
          

            return View();



        }
     

        // GET: Admin/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new FoodWasteEntities();
            var edit = (from ed in db.Admins
                        where ed.Id == id
                        select ed).SingleOrDefault();
            db.SaveChanges();
            return View(edit);
        }
    

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(Admin admins)
        {

            
                var db = new FoodWasteEntities();
            var edit = db.Admins.Find(admins.Id);
               /* var edit = (from b in db.Admins
                           where b.Id == admins.Id
                           select b).SingleOrDefault();*/
                db.Entry(edit).CurrentValues.SetValues(admins);

                db.SaveChanges();

                return RedirectToAction("Index");



            
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var db = new FoodWasteEntities();
            
            db.Admins.Remove(db.Admins.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
