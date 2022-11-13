using NGO.DB;
using NGO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGO.Repo
{
    public class RequestDetailsRepo
    {
        public static List<RequestDetailsModel> Get()
        {
            var db = new FoodWasteEntities();
            var Request = new List<RequestDetailsModel>();
            foreach (var item in db.RequestDetails)
            {
                Request.Add(new RequestDetailsModel()
                {
                    Id = item.Id,
                    EmployeeID = item.EmployeeID,
                    RequestId = item.RequestId,

                });
            }
            return Request;

        }
        public static RequestDetailsModel Get(int id)
        {
            var db = new FoodWasteEntities();
            var dbct = db.RequestDetails.Find(id);
            return new RequestDetailsModel()
            {
                Id = dbct.Id,
                EmployeeID = dbct.EmployeeID,
                RequestId = dbct.RequestId,


            };
        }
        public static void Create(RequestDetailsModel add)
        {
            var db = new FoodWasteEntities();
            db.RequestDetails.Add(new RequestDetail()
            {
                Id = add.Id,
                RequestId = add.RequestId,
                EmployeeID = add.EmployeeID,

            });
            db.SaveChanges();
        }
    }
}
