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

        [Display(Name = "Day that the drink special occurs: ")]
        public DayOfWeek DayOfTheWeek { get; set; }

        [Display(Name = "Type Of Drink")]
        public string TypeOfDrink { get; set; }

        [Display(Name = "Drink Price")]
        public double DrinkPrice { get; set; }

        [Display(Name = "Happy Hour Start Time")] 
        public DateTime HappyHourStartTime { get; set; }

        [Display(Name = "Happy Hour End Time")]
        public DateTime HappyHourEndTime { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
