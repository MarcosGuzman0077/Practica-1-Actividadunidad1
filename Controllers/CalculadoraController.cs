using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: Calculadora
        public ActionResult Sumar(double a, double b)
        {
            ViewBag.Operacion = "Suma";
            ViewBag.Resultado = a + b;
            return View("Resultado");
        }

        public ActionResult Restar(double a, double b)
        {
            ViewBag.Operacion = "Resta";
            ViewBag.Resultado = a - b;
            return View("Resultado");
        }

        public ActionResult Multiplicar(double a, double b)
        {
            ViewBag.Operacion = "Multiplicación";
            ViewBag.Resultado = a * b;
            return View("Resultado");
        }

        public ActionResult Dividir(double a, double b)
        {
            ViewBag.Operacion = "División";
            if (b == 0)
                ViewBag.Resultado = "Error: No se puede dividir por cero.";
            else
                ViewBag.Resultado = a / b;

            return View("Resultado");
        }
    }
}