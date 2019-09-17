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

        [Display(Name = "Bar")]
        public string barName { get; set; }

        [Display(Name = "Address")]
        public string address { get; set; }

        [Display(Name = "City")]
        public string city { get; set; }

        [Display(Name = "State")]
        public string state { get; set; }

        [Display(Name = "Zipcode")]
        public int zipcode { get; set; }

        [Display(Name = "Day of the Week")]
        public DayOfWeek weekDay { get; set; }

        [Display(Name = "Type of Alcohol/Drink")]
        public string typeOfDrink { get; set; }

        [Display(Name = "Type of Bar")]
        public string atmosphere { get; set; }

        [Display(Name = "Rating")]
        public int rating { get; set; }

        [Display(Name = "Open from ")]
        public TimeSpan barOpen { get; set; }

        [Display(Name = "To ")]
        public TimeSpan barClose { get; set; }

        [Display(Name = "Happy Hour start time ")]
        public TimeSpan happyHourStartTime { get; set; }

        [Display(Name = "Happy Hour end time ")]
        public TimeSpan happyHourEndTime { get; set; }

        [Display(Name = "Potential Customer")]
        public int potentialCustomers { get; set; }
   
    }
}
