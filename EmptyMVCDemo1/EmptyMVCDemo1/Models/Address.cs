using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmptyMVCDemo1.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}