using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practica_2.Models
{
    public class Registro
    {
        public string numero { get; set; }
        public DateTime fecha { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public double precio { get; }

        public double tm { get; set; }

        public Registro()
        {
            numero = "";
            fecha = DateTime.Today;
            nombre = "";
            descripcion = "";
            precio = 150 ;
            tm = 0 ;
        }

        //metodos

        public double Costo() { return precio * tm; }
        public double Seguro() { return Costo() * 0.02;  }

        public double Monto() { return Costo() + Seguro(); }

        public double IGV() { return Monto() * 0.18; }

        public double MontoTotal() { return Monto() * IGV(); }



    }
}