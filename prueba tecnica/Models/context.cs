using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace prueba_tecnica.Models
{
   
        public class context : DbContext
        {
            public context() : base("context") {}

            public DbSet<reporte> reportes{ get; set; }
        }
    }
