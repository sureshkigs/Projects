using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EMCORWebApplication.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            :base("EMCORConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<UserClass> UserList { get; set; }




    }
}