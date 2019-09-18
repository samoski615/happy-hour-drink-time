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

        public enum DayOfWeek { };  //drop down for the bar owner to select what day the bar is open? and what day/s theres going to be happy hour specials

        [Display(Name = "Atmosphere")]
        public string atmosphere { get; set; }

        [Display(Name = "Rating")]
        public int rating { get; set; }

        [Display(Name = "Open from:")]
        public DateTime hoursOfOperationStartTime { get; set; }

        [Display(Name = "To:")]
        public DateTime hoursOfOperationEndTime { get; set; }


        [DisplayFormat(DataFormatString = "Time is {0:t}")]
        [Display(Name = "Happy Hour start time:")]
        public DateTime happyHourStartTime { get; set; }

        [Display(Name = "Happy Hour end time:")]
        public DateTime happyHourEndTime { get; set; }


        [Display(Name = "Potential Customer")]
        public string potentialCustomers { get; set; }
   
    }
}
