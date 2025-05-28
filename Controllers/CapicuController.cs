using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CapicuController : Controller
    {
        // GET: Capicu
        public ActionResult Verificar(int? numero)
        {
            if (numero == null)
            {
                ViewBag.Mensaje = "Debe ingresar un número.";
            }
            else
            {
                string original = numero.ToString();
                char[] invertidoArray = original.ToCharArray();
                System.Array.Reverse(invertidoArray);
                string invertido = new string(invertidoArray);

                if (original == invertido)
                {
                    ViewBag.Mensaje = $"El número {numero} es capicúa.";
                }
                else
                {
                    ViewBag.Mensaje = $"El número {numero} no es capicúa.";
                }
            }

            return View();
        }
    }
}