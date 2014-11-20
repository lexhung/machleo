using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WSExample.Models;

namespace WSExample.DBContext
{
    public class TestWSContext : DbContext
    {
        public TestWSContext() : base("TestEF")
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Class> Class { get; set; }
    }
}