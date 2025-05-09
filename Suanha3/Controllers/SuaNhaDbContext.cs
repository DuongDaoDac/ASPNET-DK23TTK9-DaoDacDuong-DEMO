using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Suanha3.Models;

namespace Suanha3.Models
{
    public class SuaNhaDbContext : DbContext
    {
        internal object AdminAccounts;

        // name phải khớp với connectionStrings trong Web.config
        public SuaNhaDbContext() : base("Name=SuaNhaDbContext") { }

        public DbSet<Service> Services { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<AdminUser> AdminUser { get; set; }
        



    }
}