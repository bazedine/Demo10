using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Demo10.Models
{
    public class BddContext : DbContext
    {

        public BddContext() : base("name=BddContext")
            {

        }

    public DbSet<Sondage> Sondages { get; set; }
     public DbSet<Resto> Restos { get; set; }
    
       }
}