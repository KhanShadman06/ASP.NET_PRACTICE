using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {

        public static Irepo<Group, int, bool> GroupDataAccess() 
        {
            return new GroupRepo();
        }

        public static Irepo<Donor, int, Donor> DonorDataAccess() 
        {
           return new DonorsRepo();
          
        }
        public static Irepo<User, string, User> UserDataAccess() 
        {
            return new UserRepo();
        }
        public static IAuth AuthData()
        {
            return new UserRepo();
        }
    }
}
