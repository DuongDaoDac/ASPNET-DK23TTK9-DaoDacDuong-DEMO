namespace Suanha3.Migrations
{
    using Suanha3.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Suanha3.Models.SuanhaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Suanha3.Models.SuanhaDbContext";
        }

        protected override void Seed(Suanha3.Models.SuanhaDbContext context)
        {
            // Seed admin user
            if (!context.AdminUsers.Any())
            {
                context.AdminUsers.Add(new AdminUser { Username = "admin", Password = "123456" });
            }

            // Lưu thay đổi
            context.SaveChanges();
        }
    }
}
