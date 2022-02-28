using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrafikSkola.Models;

namespace TrafikSkola.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
             public DbSet<Driver> Drivers { get; set; }
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Booking> Bookings { get; set; }
       
    }
}

