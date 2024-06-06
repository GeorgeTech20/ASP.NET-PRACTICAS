using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practica_4.Models
{
    public class Base
    {
        public string nombre { get; set; }
        public string departamento { get; set; }

        public double tm { get; set; }

        public double tarifa { get; }


        public Base()
         {
            tm = 0;
            tarifa = 150;
         }

        public double Flete()
        {
            return tm * tarifa;
        }
    }
}