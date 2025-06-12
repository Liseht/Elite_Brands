using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prueba_tecnica.Models
{
    public class reporte
    {

        [Key]
            public int producto { get; set; }
            public string descripcion { get; set; }
            public double costo { get; set; }
            public double precio { get; set; }
            public int existencia { get; set; }
        }
    }
