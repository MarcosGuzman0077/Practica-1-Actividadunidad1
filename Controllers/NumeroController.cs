using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class NumeroController : Controller
    {
        // GET: Numero
       
            public ActionResult ParImpar(int? numero)
            {
                if (numero == null)
                {
                    ViewBag.Mensaje = "No se ha proporcionado un número.";
                }
                else if (numero % 2 == 0)
                {
                    ViewBag.Mensaje = $"El número {numero} es par.";
                }
                else
                {
                    ViewBag.Mensaje = $"El número {numero} es impar.";
                }

                return View();
            }
        }
    }