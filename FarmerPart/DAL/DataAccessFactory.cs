using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {

        public static Irepo<Farmer, int, Farmer> FarmerDataAccess()
        {
            return new FarmerRepo();
        }

        public static Irepo<Equipment,int,Equipment> EquipmentDataAccess()
        {
            return new EquipmentRepo();

        }
        public static Irepo<Loan,int,Loan> LoanDataAccess()
        {
            return new LoanRepo();
        }
        
    }
}
