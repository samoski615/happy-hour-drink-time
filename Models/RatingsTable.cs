using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHourTracker.Models
{
    public class RatingsTable
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Customer Ratings")]
        public int CustomerRating { get; set; }

        [ForeignKey("BarOwner")]
        public int BarOwnerId { get; set; }
        public BarOwner BarOwner { get; set; }

        [ForeignKey("Drinkers")]
        public int DrinkConsumersId { get; set; }
        public DrinkConsumers DrinkConsumers { get; set; }

    }
}
