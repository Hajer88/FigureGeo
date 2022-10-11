using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    internal class Triangle : FigureGeometrique
    {
        public Color couleur { get; set; }

        public double hauteur { get; set; }
        public double cote1 { get; set; }
        public double cote2 { get; set; }
        public double cote3 { get; set; }


        public Triangle()
        {
        }

        public override double CalculerAir()
        {
            return (cote1 * hauteur) / 2;

        }

        public override double CalculerPerimetre()
        {
            return (cote1 + cote2 + cote3);
        }

        public void Afficher(Triangle forme)
        {
            Console.WriteLine(" la couleur est : {0} l'aire est {1} perimetre est {2}", 
               couleur, forme.CalculerAir(), forme.CalculerPerimetre());
        }


        public void Initialiser(Triangle t)
        {

            t.couleur = Color.blanc;
            t.cote1 = double.Parse(Console.ReadLine());
            t.cote2 = double.Parse(Console.ReadLine());
            t.cote3 = double.Parse(Console.ReadLine());
            t.hauteur = double.Parse(Console.ReadLine());

        }
    }
}
