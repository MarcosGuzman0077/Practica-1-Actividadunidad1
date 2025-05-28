using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class FraseController : Controller
    {
        // GET: Frase
        public ActionResult ContarPalabras(string texto)
        {
            int cantidad = 0;

            if (!string.IsNullOrWhiteSpace(texto))
            {
                // Divide por espacios, eliminando vacíos
                cantidad = texto.Split(new char[] { ' ' },
                                       System.StringSplitOptions.RemoveEmptyEntries).Length;
            }

            ViewBag.Texto = texto;
            ViewBag.CantidadPalabras = cantidad;

            return View();
        }
    }
}