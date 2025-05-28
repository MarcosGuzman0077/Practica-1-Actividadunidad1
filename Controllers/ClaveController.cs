using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

namespace ActividadUnidad1.Controllers
{
    public class ClaveController : Controller
    {
        // GET: Clave
        public ActionResult Segura(string clave)
        {
            if (string.IsNullOrEmpty(clave))
            {
                ViewBag.Mensaje = "Debe ingresar una contraseña.";
            }
            else
            {
                bool tieneMinimo8 = clave.Length >= 8;
                bool tieneMayuscula = Regex.IsMatch(clave, "[A-Z]");
                bool tieneNumero = Regex.IsMatch(clave, "[0-9]");

                if (tieneMinimo8 && tieneMayuscula && tieneNumero)
                {
                    ViewBag.Mensaje = "La contraseña es segura.";
                }
                else
                {
                    ViewBag.Mensaje = "La contraseña NO es segura. Debe tener al menos 8 caracteres, una mayúscula y un número.";
                }
            }

            return View();
        }
    }
}