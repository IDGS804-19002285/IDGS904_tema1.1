using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;

namespace IDGS904_tema1.Controllers
{
    public class TienditaController : Controller
    {
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Nombre = "Pedro",
                Edad = 20,
                Activo = true,
                Inscrito = new DateTime(2023, 1, 1)
            };
            ViewBag.Alumnos = alumno;
            return View();
        }
        public ActionResult Registrar () {

            return View();
        }
        public ActionResult Temperatura()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Temperatura(Temperatura temperatura){
            var model = new Temperatura();
            string fin = model.Convertir(temperatura.temp, temperatura.conv);
            return RedirectToAction("Resultado",new RouteValueDictionary(new { resultado = fin }));
            
        }
        public ActionResult Resultado(string resultado) {
            ViewBag.Tem = resultado;
            return View();
        }
    }
}