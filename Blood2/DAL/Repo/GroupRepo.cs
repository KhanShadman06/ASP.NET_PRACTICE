using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class GroupRepo : Irepo<Group, int, bool>
    {
        BloodDonateEntities db;
        internal GroupRepo()
        {
            db = new BloodDonateEntities();
        }
        public bool Add(Group obj)
        {
            db.Groups.Add(obj);

            return db.SaveChanges() > 0;

        }

        public bool Delete(int id)
        {
            db.Groups.Remove(db.Groups.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<Group> Get()
        {
            return db.Groups.ToList();
        }

        public Group Get(int id)
        {
            return db.Groups.Find(id);
        }

        public bool Update(Group obj)
        {
            var ext = db.Groups.Find(obj.Id);

            db.Entry(ext).CurrentValues.SetValues(obj);

            return db.SaveChanges() > 0;
        }
    }
}
