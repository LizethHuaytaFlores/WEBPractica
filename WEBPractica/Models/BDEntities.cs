using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WEBPractica.Models
{
    public class BDEntities:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}