using System;
using System.Data;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Types valeur
            int i;
            DateTime d = DateTime.Now;

            // Types référence
            Personne p = new Personne();
            DataSet ds = new DataSet();
        }
    }
    class Personne
    {
        // Static
        public static int Nombre = 0;

        // Dynamic
        public string Nom;
        public string Prenom;
        public int Age;
    }
}
