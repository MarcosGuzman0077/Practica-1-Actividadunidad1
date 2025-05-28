using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class PalindromaController : Controller
    {
        // GET: Palindroma
        
        
            public ActionResult Palabra(string texto)
            {
                bool esPalindroma = false;

                if (!string.IsNullOrEmpty(texto))
                {
                    string palabra = texto.ToLower().Replace(" ", "");
                    char[] arr = palabra.ToCharArray();
                    System.Array.Reverse(arr);
                    string invertida = new string(arr);
                    esPalindroma = palabra == invertida;
                }

                ViewBag.Texto = texto;
                ViewBag.EsPalindroma = esPalindroma;

                return View();
            }
        }
    }
