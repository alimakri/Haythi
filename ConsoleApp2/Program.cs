using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne Haytham = new Personne();
            Haytham.Nom = "Bouayad";
            Haytham.Prenom = "Haytham";
            Haytham.Age = 21;
            Personne.Nombre++;

            Personne Thierno = new Personne();
            Thierno.Nom = "Barry";
            Thierno.Prenom = "Thierno";
            Thierno.Age = 18;
            Personne.Nombre++;

            List<Personne> maListe = new List<Personne>();
            maListe.Add(Haytham);
            maListe.Add(Thierno);

            Console.WriteLine("Nombre de personnes : " + Personne.Nombre);
            foreach(Personne p in maListe)
            {
                Console.WriteLine(p.Nom + " " + p.Prenom);
            }
            Console.Read();
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
