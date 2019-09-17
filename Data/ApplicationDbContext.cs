using System;
using System.Collections.Generic;
using System.Text;
using HappyHourTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HappyHourTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<BarOwner> BarOwners { get; set; }
        public DbSet<Bar> Bar { get; set; }

        public DbSet<DrinkSpecial> DrinkSpecials{ get; set; }
        public DbSet<DrinkConsumers> Drinkers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
