using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Suanha3.Models
{
    public class SuanhaDbContext : DbContext
    {
        // Constructor chỉ định chuỗi kết nối
        public SuanhaDbContext() : base("name=SuanhaDbContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SuaNhaDbContext>());
        }

        // Các DbSet tương ứng với các bảng
        public DbSet<Service> Services { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }

    }
}
