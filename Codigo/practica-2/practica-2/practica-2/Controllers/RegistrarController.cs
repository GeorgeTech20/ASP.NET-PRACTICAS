using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practica_2.Models;

namespace practica_2.Controllers
{
    public class RegistrarController : Controller
    {
        public ActionResult ActiontRgistrar() 
        {
            return View(new Registro());
        }

        [HttpPost] public ActionResult ActiontRgistrar(Registro reg) 
        {
            ViewBag.Costo = reg.Costo().ToString("####.#0");
            ViewBag.Seguro = reg.Seguro().ToString("####.#0");
            ViewBag.Monto = reg.Monto().ToString("####.#0");
            ViewBag.IGV = reg.IGV().ToString("####.#0");
            ViewBag.MontoTotal = reg.MontoTotal().ToString("####.#0");
            return View(reg);
        }
    }
}