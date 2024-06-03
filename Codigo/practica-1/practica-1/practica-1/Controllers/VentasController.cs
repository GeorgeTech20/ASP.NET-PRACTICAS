using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practica_1.Models;


namespace practica_1.Controllers
{
    public class VentasController : Controller
    {

        public ActionResult ActionVenta() {
            return View(new Venta());
        }

        [HttpPost] public ActionResult ActionVenta(Venta reg) 
        {
            ViewBag.descuento = reg.Descuento();
            ViewBag.neto = reg.Neto();
            return View(reg);
        }

    }
}