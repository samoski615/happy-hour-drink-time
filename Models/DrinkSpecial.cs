using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHourTracker.Models
{
    public class DrinkSpecial
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Day that the drink special occurs:")]
        public string DayOfTheWeek { get; set; }

        [Display(Name = "Drink")]
        public string TypeOfdrink { get; set; }

        [Display(Name = "Main alcohol in drink")]
        public string MainTypeOfAlcohol { get; set; }

        [Display(Name = "Price for HappyHour special")]
        public double DrinkPrice { get; set; }

        [Display(Name = "Time that HappyHour starts")] 
        public string TimeHappyHourStarts { get; set; }

        [Display(Name = "Time that HappyHour ends")]
        public string TimeHappyHourEnds { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public enum DayOfWeek { }

    }
}
