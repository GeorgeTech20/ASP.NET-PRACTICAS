using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practica_3.Models;

namespace practica_3.Controllers
{
    public class PlantillaController : Controller
    {

        public ActionResult Boleta()
        {
            return View(new Haberes());
        }

        [HttpPost]public ActionResult Boleta(Haberes reg)
        {
            ViewBag.bonificacion = reg.Bonificacion();
            ViewBag.remuneración = reg.Remuneración();
            ViewBag.aportación = reg.Aportación();
            ViewBag.neto = reg.Neto();
            return View(reg);
        }
    }
}