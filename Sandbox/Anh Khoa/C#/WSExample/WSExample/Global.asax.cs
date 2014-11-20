using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WSExample.DBContext;
using WSExample.Models;

namespace WSExample
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer(new CreateDatabaseIfNotExists<TestWSContext>());

            var db = new TestWSContext();

            var classtTest = new Class
            {
                Id = Guid.NewGuid(),
                Name = "11CLC"
            };

          

            db.Class.Add(classtTest);

            if (db.SaveChanges() > 0)
            {
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    Username = "Khoa",
                    Password = "test",
                    ClassID = classtTest.Id
                };

                db.User.Add(user);
                bool isSuccessful = db.SaveChanges() > 0;
            }
        }
    }
}