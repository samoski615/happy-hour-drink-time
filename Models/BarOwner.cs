using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHourTracker.Models
{
    public class BarOwner
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Bar Name")]
        public string BarName { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zipcode")]
        public int Zipcode { get; set; }

        [Display(Name = "Bar Atmosphere")]
        public string TypeOfBar { get; set; }

        [Display(Name = "Rating")]
        public int Rating { get; set; }

        [Display(Name = "Bar open from: ")]
        public DateTime BarOpen { get; set; }

        [Display(Name = "Bar closes at: ")]
        public DateTime BarClose { get; set; }

        [Display(Name = "Potential Customer")]
        public int PotentialCustomers { get; set; }

    }
}
