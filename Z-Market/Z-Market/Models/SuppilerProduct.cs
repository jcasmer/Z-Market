using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class SuppilerProduct
    {
        [Key]
        public int SuppilerProductID { get; set; }

        public int SupplierID { get; set; }

        public int id { get; set; }  //id producto

        public virtual Supplier Supplier { get; set; } // empleado relacion con tipo de documento

        public virtual Product Product { get; set; } // empleado relacion con tipo de documento
    }
}