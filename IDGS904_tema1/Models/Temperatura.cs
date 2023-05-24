using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Temperatura
    {
        public int temp{ get; set; }
        public int conv{ get; set; }
        public string Convertir(int temperatura, int convertir) {
            double value = 0;
            String grado = "";
            if (convertir == 1){
                value = (temperatura * 1.8) + 32;
                grado = " F°";
            }
            else{
                value = (temperatura - 32) / 1.8;
                grado = " C°";
            }
            return value.ToString($"0.{new string('#', 2)}")+ grado;
        }
    }
}