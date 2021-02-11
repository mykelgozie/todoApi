using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Modelslibrary;
using System;
using System.Collections.Generic;
using System.Text;



namespace serviceslibrary.data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }



        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Cartegory> Cartegories { get; set; }



    }
}
