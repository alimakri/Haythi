using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto mercedes;
            Moto kawasaki = new Moto();
            mercedes.Apparence = Couleur.Bleu;

            // Types valeurs
            int i = 1;
            double pi1 = 3.14;
            float pi2 = 3.14f;
            decimal pi3 = 3.14M;
            string s = "une phrase très courte";
            bool b = false;
            char c = 'A';

            Nullable<int> j = null;
            Nullable<bool> b2 = null;
            Nullable<char> c2 = null;
            
        }
    }
    struct Auto
    {
        public Couleur Apparence;
    }
    enum Couleur
    {
        Bleu, Rouge, Vert, Marron, Magenta
    }
    class Moto
    {

    }
}
