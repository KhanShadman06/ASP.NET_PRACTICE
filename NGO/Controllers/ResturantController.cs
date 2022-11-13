using NGO.Models;
using NGO.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGO.Controllers
{
    public class ResturantController : Controller
    {
        // GET: Resturant
        public ActionResult Index()
        {
            return View(ResturantRepo.Get());
        }
        public ActionResult ResDetails(int id)
        {
            var Request = ResturantRepo.Get(id);
            return View(Request);
        }

        [HttpGet]
        public ActionResult Request() 
        { 
        
          return View();
        
        
        }
        [HttpPost]
        public ActionResult Request(RequestTableModel Request)
        {
            if (ModelState.IsValid)
            {

                RequestTableRepo.Create(Request);
                return RedirectToAction("Index");
            }
            return View(Request);
        }
        public ActionResult Details(int id)
        {
            var Request = RequestTableRepo.Get(id);
            return View(Request);
        }

    }
}