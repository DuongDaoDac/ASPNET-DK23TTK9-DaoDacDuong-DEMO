using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using Suanha3.Models;

namespace Suanha3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Đăng ký lớp DatabaseInitializer
            Database.SetInitializer(new DatabaseInitializer());
        }

        private void SeedAdmin()
        {
            using (var db = new SuaNhaDbContext())
            {
                if (!db.AdminUser.Any())
                {
                    db.AdminUser.Add(new AdminUser
                    {
                        Username = "admin",
                        Password = "123456"
                    });
                    db.SaveChanges();
                }
            }
        }
    }
}


