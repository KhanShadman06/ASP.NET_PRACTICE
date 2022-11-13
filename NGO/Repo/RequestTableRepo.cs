using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NGO.DB;
using NGO.Models;

namespace NGO.Repo
{
    public class RequestTableRepo
    {
        public static List<RequestTableModel> Get()
        {
            var db = new FoodWasteEntities();
            var RequestTb = new List<RequestTableModel>();
            foreach (var item in db.RequestTables)
            {
                RequestTb.Add(new RequestTableModel()
                {
                    Id = item.Id,
                    Quantity = item.Quantity,
                    ReserveDate = item.ReserveDate,
                    ResturantId = item.ResturantId,
                    FoodName = item.FoodName,

                });
            }
            return RequestTb;
        }
        public static RequestTableModel Get(int id)
        {
            var db = new FoodWasteEntities();
            var dbct = db.RequestTables.Find(id);
            return new RequestTableModel()
            {
                Id = dbct.Id,
                Status = dbct.Status,
                Quantity = dbct.Quantity,
                ResturantId = dbct.ResturantId,
                ReserveDate = dbct.ReserveDate,

            };
        }
        public static void Create(RequestTableModel add)
        {
            var db = new FoodWasteEntities();
            db.RequestTables.Add(new RequestTable()
            {
                Id = add.Id,
                Status = add.Status,
                Quantity = add.Quantity,
                ReserveDate = add.ReserveDate,
                ResturantId = add.ResturantId,

            });
            db.SaveChanges();
        }
    }
}