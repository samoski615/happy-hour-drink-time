﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHourTracker.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [NotMapped]
        public bool IsBarOwner { get; set; }
    }
}
