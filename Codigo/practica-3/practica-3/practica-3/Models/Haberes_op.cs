using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using practica_3.Models;

namespace practica_3.Models
{
    public partial class Haberes 
    {
        public double Bonificacion() 
        {
            return 0.25 * basico;
        }

        public double Remuneración()
        {
            return basico + Bonificacion();
        }

        public double Aportación()
        {
            return aportacion == "AFP" ? 0.11 * Remuneración(): 0.13*Remuneración();
        }

        public double Neto()
        {
            return Remuneración() - Aportación();
        }

    }
}