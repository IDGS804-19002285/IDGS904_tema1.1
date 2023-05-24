using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TrinaguloController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Triangulo ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Triangulo(triangulo triangulos)
        {
            var triangulo2 = new triangulo();
            double punto1=triangulo2.Calcular(triangulos.x1,triangulos.y1, triangulos.x2, triangulos.y2);
            double punto2 = triangulo2.Calcular(triangulos.x2, triangulos.y2, triangulos.x3, triangulos.y3);
            double punto3 = triangulo2.Calcular(triangulos.x3, triangulos.y3, triangulos.x1, triangulos.y1);

            double ladosTotal = (punto1 + punto2 + punto3) / 2;
            double areaTotal = Math.Sqrt(ladosTotal * (ladosTotal-punto1) * (ladosTotal-punto2) * (ladosTotal-punto3));

            String forma = "";
            double[] lados = {punto1,punto2,punto3};
            Array.Sort(lados);
            String tipo = "";
            double area;

            
            if (lados[2] >= (lados[1] + lados[0]))
            {
                forma = "Sintaxis Error";
            }
            else
            {
                if (punto1 != punto2 && punto2 != punto3 && punto3 != punto1)
                { forma = "Escaleno"; }
                if (punto1 == punto2 || punto2 == punto3 || punto3 == punto1)
                { forma = "Isoseles"; }
                if (punto1 == punto2 && punto2 == punto3 && punto3 == punto1)
                { forma = "Equilatero"; }

                ViewBag.Area = areaTotal;
            }
            if (forma != "Escaleno" && forma != "Isoseles" && forma != "Equilatero")
            {
                ViewBag.Area = "Sintaxis Error";
            }
            ViewBag.Tipo = forma;
            
            return View();
        }
    }
}