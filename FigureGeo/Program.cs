// See https://aka.ms/new-console-template for more information
using FigureGeo;
Console.WriteLine("Hello, World!");
Triangle f1 = new Triangle();
Cercle f2 = new Cercle();
Rectangle f3 = new Rectangle();
f1.Initialiser(f1);
f1.CalculerPerimetre();
f1.CalculerAir();
f2.CalculerPerimetre();
f2.CalculerAir();
f3.CalculerPerimetre();
f3.CalculerAir();
f1.Afficher(f1);
//f2.Afficher(f2);
f3.Afficher(f3);
f1.CalculerPerimetre();
f1.CalculerAir();

