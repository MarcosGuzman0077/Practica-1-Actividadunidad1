using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Multiplicar(int? numero)
        {
            if (numero == null)
            {
                ViewBag.Mensaje = "Debe proporcionar un número.";
                return View();
            }

            int valor = numero.Value;
            List<string> tabla = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                tabla.Add($"{valor} x {i} = {valor * i}");
            }

            ViewBag.Numero = valor;
            ViewBag.Tabla = tabla;

            return View();
        }
    }
}