using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.Largeur = 2;
            rect1.Longueur = 3;
            rect1.Calculer();

            Circle cercle = new Circle();
            cercle.Diametre = 2;
            cercle.Calculer();

            Geometry g;
            g = new Circle();
            ((Circle)g).Diametre = 7;
            g.Calculer();

            g = rect1;
            g.Calculer();

            Geometry h = g;
            ((Rectangle)h).Longueur = 77;
            g = null;
            {
                Geometry k = rect1;
            }
            rect1 = null;
            h = null;

            for(int i=0; i < int.MaxValue; i++)
            {
                using (Rectangle r = new Rectangle())
                {

                }
                
            }

            ITracage dessin = new Circle();
            (dessin as Rectangle).Longueur = 12;
            (dessin as Rectangle).Largeur = 12;
            dessin.Dessiner();

        }
    }
    abstract class Geometry
    {
        public double Surface;
        public double Perimetre;
        public abstract void Calculer();
    }
    class Rectangle : Geometry, IDisposable, ITracage
    {
        public double Longueur;
        public double Largeur;
        public override void Calculer()
        {
            Perimetre = 2 * (Longueur + Largeur);
            Surface = Longueur * Largeur;
        }

        public void Dessiner()
        {
            
        }

        public void Dispose()
        {

        }
    }
    class Circle : Geometry, ITracage
    {
        public double Diametre;
        public override void Calculer()
        {
            Perimetre = Math.PI * Diametre;
            Surface = Math.PI * Math.Pow(Diametre / 2, 2);
        }
        public void Dessiner()
        {

        }
    }
    class Image : ITracage
    {
        public void Dessiner()
        {
        }
    }
    interface ITracage
    {
        void Dessiner();
    }
}
