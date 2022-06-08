using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var liste = new Personnes();

            liste.Add(new Personne
            {
                Nom = "Blein",
                Prenom = "c"
            });
            liste.Add(new Personne
            {
                Nom = "Makri",
                Prenom = "Ali"
            });
            liste.Add(new Personne
            {
                Nom = "Bouayad",
                Prenom = "Haytham"
            });
            liste.Add(new Personne
            {
                Nom = "Barry",
                Prenom = "Thierno"
            });

            var premier = liste[0];
            var n = liste.Count;

            foreach (var p in liste)
            {
                Console.WriteLine(p.Nom);
            }
            Console.Read();
        }
    }
    class Personne
    {
        public string Nom;
        public string Prenom;
    }
    class Personnes : IEnumerable<Personne>
    {
        private List<Personne> ListeInterne = new List<Personne>();
        public int Count
        {
            get
            {
                return ListeInterne.Count;
            }
        }
        public Personne this[int index]
        {
            get
            {
                return ListeInterne[index];
            }
        }

        public void Add(Personne p)
        {
            if (!p.Nom.StartsWith("A"))
                ListeInterne.Add(p);
        }

        public IEnumerator<Personne> GetEnumerator()
        {
            return new PersonneEnumerator(ListeInterne);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PersonneEnumerator(ListeInterne);
        }
    }
    class PersonneEnumerator : IEnumerator<Personne>
    {
        private List<Personne> MaListe;
        public PersonneEnumerator(List<Personne> liste)
        {
            MaListe = liste;
        }
        private int Index = -1;
        public Personne Current
        {
            get
            {
                return MaListe[Index];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return MaListe[Index];
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            Index++;
            return Index < MaListe.Count;
        }

        public void Reset()
        {
            Index = -1;
        }
    }
}
