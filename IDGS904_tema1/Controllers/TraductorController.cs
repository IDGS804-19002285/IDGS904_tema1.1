using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: traductor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult traductor()
        {
            var arch = new traServices();
            Array esp = arch.LeerArchivoE();
            Array ing = arch.LeerArchivoI();
            ViewBag.esp = esp;
            ViewBag.ing = ing;
            return View();
        }
        public ActionResult formtraduc() { return View(); }
        [HttpPost]
        public ActionResult formtraduc(Traductor T)
        {
            var ope1 = new traServices();
            ope1.GuardarArvchivo(T);
            return View();
        }
        public ActionResult resultadotraduc(Traductor T)
        {
            var arch = new traServices();
            if (T.lenguaje == 0) { return RedirectToAction("formtraduc"); }

            Array esp = arch.LeerArchivoE();
            Array ing = arch.LeerArchivoI();
            String palabra = null;
            String idioma = null;

            if (T.lenguaje == 1)
            {
                idioma = "Español";
                foreach (string item in ing)
                {
                    if (item == T.palabra)
                    {
                        int indice = Array.IndexOf(ing, item);
                        palabra = (string)esp.GetValue(indice);
                    }
                }
            }
            if (T.lenguaje == 2)
            {
                idioma = "Ingles";
                foreach (string item in esp)
                {
                    if (item == T.palabra)
                    {
                        int indice = Array.IndexOf(esp, item);
                        palabra = (string)ing.GetValue(indice);
                    }
                }
            }

            ViewBag.palabra = (palabra == null ? "0 Coincidencias" : "La palabra '" + T.palabra + "'" + " traducida al " + idioma + " es '" + palabra + "'");
            return View();
        }
    }
}