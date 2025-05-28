using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class TemperaturaController : Controller
    {
        // GET: Temperatura
        public ActionResult Convertir(double? celsius)
        {
            if (celsius == null)
            {
                ViewBag.Mensaje = "Debe proporcionar una temperatura en grados Celsius.";
            }
            else
            {
                double fahrenheit = (celsius.Value * 9 / 5) + 32;
                ViewBag.Celsius = celsius.Value;
                ViewBag.Fahrenheit = fahrenheit;
            }

            return View();
        }
    }
}