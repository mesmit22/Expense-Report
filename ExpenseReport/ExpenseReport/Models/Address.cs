using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpenseReport.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}