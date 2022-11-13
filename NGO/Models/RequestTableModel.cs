using NGO.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGO.Models
{
    public class RequestTableModel
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequestTableModel()
        {
            this.RequestDetails = new HashSet<RequestDetail>();
        }

        public int Id { get; set; }
        public string FoodName { get; set; }
        public int ResturantId { get; set; }
        public string ReserveDate { get; set; }
        public string Quantity { get; set; }
      
        

        public virtual ResturantModel Resturant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestDetail> RequestDetails { get; set; }
    }
}