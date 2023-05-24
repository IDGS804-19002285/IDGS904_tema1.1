using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class triangulo
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }


        public double Calcular(int x1, int y1, int x2, int y2)
        {
            int X = x2 - x1;
            int Y = y2 - y1;
            double res = (X * X) + (Y * Y);
            return Math.Sqrt(res);
        }

    }
}