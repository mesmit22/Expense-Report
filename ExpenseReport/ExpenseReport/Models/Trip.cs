using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpenseReport.Models
{
    public class Trip
    {
        public int TripID { get; set; }
        [Display(Name = "Starting Address")]
        public Address StartingAddress { get; set; }
        [Display(Name = "Ending Addres")]
        public Address EndingAddress { get; set; }
        public DateTime Date { get; set; }
    }
}