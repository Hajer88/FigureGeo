using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    internal abstract class FigureGeometrique
    {
        public double air { get; set; }
        public double perimetre { get; set; }
        public enum Color
        {
            rouge,
            bleu,
            vert,
            noir,
            blanc

        }
        public abstract double CalculerAir();
        public abstract double CalculerPerimetre();
    }
}
