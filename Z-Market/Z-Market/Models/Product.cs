using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z_Market.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime LastBuy { get; set; }
        public float Stock { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<SuppilerProduct> SuppilerProduct { get; set; }
    }
}