using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CnxCodeFirst.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<personas> personas { get; set; }
        public DbSet<tipospersonas> tipospersonas { get; set; }
        public DbSet<tiponaturalezas> tiponaturalezas { get; set; }


    }
}