using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practica_3.Models
{
    public partial class Haberes
    {
        public int dni { get; set; }

        public string nombre { get; set; }

        public double categoria { get; set; }

        public double basico { get; set; } 

        public string aportacion { get; set; }
    }  
}