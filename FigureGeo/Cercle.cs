using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    internal class Cercle : FigureGeometrique
    {
        public double rayon { get; set; }
        const double Pi = 3.14;
        public Color couleur { get; set; }
        public Cercle()
        {
        }

        public void Initialiser(Cercle c)
        {
            c.couleur = Color.rouge;
            c.rayon = double.Parse(Console.ReadLine());     

        }

        public override double CalculerAir()
        {
            return rayon * rayon * Pi;
        }

        public override double CalculerPerimetre()
        {
            return 2 * rayon * Pi;
        }
    }
}