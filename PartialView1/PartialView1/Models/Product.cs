using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialView1.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}