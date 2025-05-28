using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CorreoController : Controller
    {
        // GET: Correo
        public ActionResult Dominio(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@"))
            {
                ViewBag.Mensaje = "Debe proporcionar una dirección de correo válida.";
            }
            else
            {
                string[] partes = correo.Split('@');
                if (partes.Length == 2)
                {
                    ViewBag.Correo = correo;
                    ViewBag.Dominio = partes[1];
                }
                else
                {
                    ViewBag.Mensaje = "La dirección de correo no es válida.";
                }
            }

            return View();
        }
    }
}