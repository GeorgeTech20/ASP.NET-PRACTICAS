using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practica_4.Models;

namespace practica_4.Controllers
{
    public class SolucionController : Controller
    {
        public ActionResult GuiaTransporte()
        {
            return View(new IVOVIC());
        }

        [HttpPost] public ActionResult GuiaTransporte(IVOVIC reg) 
        {
            ViewBag.flete = reg.Flete().ToString("####.#0");
            return View(reg);
        }
    }
}