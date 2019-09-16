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

        [Display(Name = "Drink Specials")]
        public string drinkSpecials { get; set; }

        [Display(Name = "Atmosphere")]
        public string atmosphere { get; set; }

        [Display(Name = "Price Range")]
        public string priceRange { get; set; }

        [Display(Name = "Hours")]
        public string hours { get; set; }


    }
}
