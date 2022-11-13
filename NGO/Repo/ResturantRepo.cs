using NGO.DB;
using NGO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGO.Repo
{
    public class ResturantRepo
    {
        public static List<ResturantModel> Get()
        {
            var db = new FoodWasteEntities();
            var Resturant = new List<ResturantModel>();
            foreach (var item in db.Resturants)
            {
                Resturant.Add(new ResturantModel()
                {
                    Id = item.Id,
                    ResturantName = item.ResturantName,
                    Email = item.Email,
                    Password = item.Password,   
                    Address = item.Address,
                    
                });
            }
            return Resturant;
        }
        public static ResturantModel Get(int id)
        {
            var db = new FoodWasteEntities();
            var dbct = db.Resturants.Find(id);
            return new ResturantModel()
            {
                Id = dbct.Id,
                ResturantName= dbct.ResturantName,
                Password = dbct.Password,
                Email = dbct.Email,
                Address = dbct.Address,
               
            };
        }
        public static void Create(ResturantModel add)
        {
            var db = new FoodWasteEntities();
            db.Resturants.Add(new Resturant()
            {
                Id = add.Id,
                ResturantName = add.ResturantName,
                Password=add.Password,
                Email=add.Email,
                Address=add.Address,
               

            });
            db.SaveChanges();
        }
    }
}