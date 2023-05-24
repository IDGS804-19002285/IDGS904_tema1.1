using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class traServices
    {
        public void GuardarArvchivo(Traductor maes) {
            var idiomaEsp = maes.espanol +Environment.NewLine;
            var idiomaIng = maes.ingles + Environment.NewLine;
            var agregarEspa = HttpContext.Current.Server.MapPath("~/App_Data/TraductorESP.txt");
            var agregarIng = HttpContext.Current.Server.MapPath("~/App_Data/TraductorING.txt");
            File.AppendAllText(agregarEspa, idiomaEsp);
            File.AppendAllText(agregarIng, idiomaIng);
        }

        public Array LeerArchivoE()
        {
            Array idiomaEsp = null;
            var Espanol = HttpContext.Current.Server.MapPath("~/App_Data/TraductorESP.txt");
            if (File.Exists(Espanol)){ idiomaEsp  = File.ReadAllLines(Espanol);}
            return idiomaEsp;
        }
        public Array LeerArchivoI()
        {
            Array idiomaIng = null;
            var Ingles = HttpContext.Current.Server.MapPath("~/App_Data/TraductorING.txt");
            if (File.Exists(Ingles)) { idiomaIng = File.ReadAllLines(Ingles); }
            return idiomaIng;
        }
    }
}