using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeo
{
    internal class Rectangle : FigureGeometrique
    {
        public Color couleur { get; set; }
        public double hauteur { get; set; }
        public double largeur { get; set; }
        public string? a = null;
        public bool? b = null;
        public Rectangle()
        {
        }

        public override double CalculerAir() => hauteur * largeur;

        public override double CalculerPerimetre()
        {
            return (hauteur * largeur) / 2;
        }

        public void Afficher(Rectangle frome)
        {
            Console.WriteLine(" le couleur est : {0} l'aire est {1} perimetre est {2}", couleur, frome.CalculerAir(), frome.CalculerPerimetre());

        }

        public void Initialiser(Rectangle t)
        {
            t.couleur = Color.bleu;
            t.hauteur = double.Parse(Console.ReadLine());
            t.largeur = double.Parse(Console.ReadLine());

            t.CalculerAir();
            t.CalculerPerimetre();

        }
    }
}
