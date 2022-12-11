using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class FarmerRepo : Irepo<Farmer, int, Farmer>
    {
        Db_SmartFarmEntities db;


        internal FarmerRepo()
        {
            db = new Db_SmartFarmEntities();

        }
        public Farmer Add(Farmer obj)
        {
            db.Farmers.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Farmers.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Farmer> Get()
        {
            return db.Farmers.ToList();
        }

        public Farmer Get(int id)
        {
            return db.Farmers.Find(id);
        }

        public Farmer Update(Farmer obj)
        {
            var dbco = Get(obj.Id);
            db.Entry(dbco).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
