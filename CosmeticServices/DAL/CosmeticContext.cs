using CosmeticServices.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosmeticServices.DAL
{
    public class CosmeticContext : DbContext
    {
        public CosmeticContext() : base("CosmeticContext")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Appointment> Appointmets { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}