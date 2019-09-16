using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHourTracker.Models
{
    public class Bar
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

        public enum DayOfWeek { };

        [Display(Name = "Atmosphere")]
        public string atmosphere { get; set; }

        [Display(Name = "Rating")]
        public int rating { get; set; }

        [Display(Name = "Open from ")]
        public TimeSpan hoursOfOperationStartTime { get; set; }

        [Display(Name = "To ")]
        public TimeSpan hoursOfOperationEndTime { get; set; }

        [Display(Name = "Happy Hour start time ")]
        public TimeSpan happyHourStartTime { get; set; }

        [Display(Name = "Happy Hour end time ")]
        public TimeSpan happyHourEndTime { get; set; }

        [Display(Name = "Potential Customer")]
        public int potentialCusotmers { get; set; }
   
    }
}
