using NGO.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGO.Models
{
    public class RequestDetailsModel
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int EmployeeID { get; set; }

        public virtual EmployeeModel Employee { get; set; }
        public virtual RequestDetail RequestDetails1 { get; set; }
        public virtual RequestDetail RequestDetail1 { get; set; }
        public virtual RequestTableModel RequestTable { get; set; }
    }
}