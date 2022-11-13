using NGO.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NGO.Models;
using System.Data.Entity.Core.Metadata.Edm;

namespace NGO.Repo
{
    public class EmployeeRepo
    {
        public static List<EmployeeModel> Get()
        {
            var db = new FoodWasteEntities();
            var Employees = new List<EmployeeModel>();
            foreach (var item in db.Employees)
            {
               Employees.Add(new EmployeeModel()
                {
                   Id = item.Id,
                   EmployeeName = item.EmployeeName,
                   DOB = item.DOB,
                   Password = item.Password,
                   Email = item.Email,  
                   
                   
                });
            }
            return Employees;
        }
        public static EmployeeModel Get(int id)
        {
            var db = new FoodWasteEntities();
            var dbct = db.Employees.Find(id);
            return new EmployeeModel()
            {
               Id = dbct.Id,
               EmployeeName = dbct.EmployeeName,
               DOB =dbct.DOB,
               Password=dbct.Password,
               Email=dbct.Email,    
               
            };
        }
        public static void Create(EmployeeModel add)
        {
            var db = new FoodWasteEntities();
            db.Employees.Add(new Employee()
            {
                Id=add.Id,
                EmployeeName=add.EmployeeName,
                DOB= add.DOB,
                Password=add.Password,
                Email= add.Email,

            });
            db.SaveChanges();
        }

        

    }

}