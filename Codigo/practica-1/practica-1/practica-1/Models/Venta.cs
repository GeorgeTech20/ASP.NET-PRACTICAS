using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practica_1.Models
{
    public class Venta
    {
            
        public string nuboleta { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }

        public Venta()
        {
            nuboleta = "";
            fecha = DateTime.Today;
            cliente = "";
            descripcion = "";
            precio = 0;
        }

        public double Descuento()
        {
            if (precio == 0) return 0;
            else if (precio <= 500) return 0.02 * precio;
            else return 0.05 * precio;
        }

        public double Neto()
        {
            return precio - Descuento();
        }



    }
}