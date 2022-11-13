using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using NGO.DB;
using NGO.Models;


namespace NGO.Repo
{
    public class AdminRepo
    {
        public static List<AdminModel> Get()
        {
            var db = new FoodWasteEntities();
            var Admin = new List<AdminModel>();
            foreach (var item in db.Admins)
            {
               Admin.Add(new AdminModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email,
                    Password = item.Password,

                   
                });
            }
            return Admin;

        }
        public static AdminModel Get(int id)
        {
            var db = new FoodWasteEntities();
            var dbct = db.Admins.Find(id);
            return new AdminModel()
            {
                Id = dbct.Id,
               Name=dbct.Name,
               Password = dbct.Password,
               Email = dbct.Email,

            };
        }
        public static void Create(AdminModel add)
        {
            var db = new FoodWasteEntities();
            db.Admins.Add(new Admin()
            {
                Id = add.Id,
               Name= add.Name,
               Password= add.Password,
               Email = add.Email,

            });
            db.SaveChanges();
        }

       

        }
    }








        
    