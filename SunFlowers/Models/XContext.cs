using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SunFlowers.Models
{
    public class XContext : DbContext
    {
        public XContext() : base("XContext")
        {
        }

        public System.Data.Entity.DbSet<SunFlowers.Models.Flower> Flowers { get; set; }
    }
}