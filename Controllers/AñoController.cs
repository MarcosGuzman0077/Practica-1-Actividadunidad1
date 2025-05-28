using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class AñoController : Controller
    {
        // GET: Año
        public ActionResult Bisiesto(int? año)
        {
            if (año == null)
            {
                ViewBag.Mensaje = "Debe proporcionar un año.";
            }
            else
            {
                bool esBisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);

                if (esBisiesto)
                {
                    ViewBag.Mensaje = $"El año {año} es bisiesto.";
                }
                else
                {
                    ViewBag.Mensaje = $"El año {año} no es bisiesto.";
                }
            }

            return View();
        }
    }
}