using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //LesNombre();

            LesPlantes();


            Console.Read();
        }

        private static void LesPlantes()
        {
            var liste = new List<Plante> 
            {
                new Plante{ Nom="Cactus", IsExotique=true, NFeuilles=0, Saison = SaisonEnum.Hiver },
                new Plante{ Nom="Rosier", IsExotique=false, NFeuilles=45, Saison = SaisonEnum.Printemps },
                new Plante{ Nom="Ficus", IsExotique=false, NFeuilles=0, Saison = SaisonEnum.Automne },
                new Plante{ Nom="Sapin", IsExotique=false, NFeuilles=0, Saison = SaisonEnum.Hiver },
                new Plante{ Nom="Olivier", IsExotique=true, NFeuilles=899, Saison = SaisonEnum.Ete }
            };

            // Version lambda expression
            //var liste2 = liste
            //                    .Where(k => k.IsExotique && k.NFeuilles > 0)
            //                    .OrderBy(k => k.Nom);

            var liste2 = liste
                                .Where(k => k.Saison == SaisonEnum.Hiver)
                                .OrderBy(k => k.Nom);

            // Affichage
            foreach (var j in liste2)
            {
                Console.WriteLine(j);
            }
        }

        private static void LesNombre()
        {
            var liste = new List<int> { 25, 69, 5, 4, 33, 98 };

            // Version lambda expression
            var listeImpairs = liste
                                .Where(k => k < 50)
                                .OrderByDescending(j => j);

            // Version classique
            //var listeImpairs = new List<int>();
            //foreach(var k in liste)
            //{
            //    listeImpairs.Add(k);
            //}

            // Affichage
            foreach (var p in listeImpairs)
            {
                Console.WriteLine(p);
            }
        }
    }
    class Plante 
    {
        public string Nom;
        public bool IsExotique;
        public int NFeuilles;
        public SaisonEnum Saison;
        public override string ToString()
        {
            return $"{Nom} ({Saison})";
        }
    }
    enum SaisonEnum { Hiver, Printemps, Ete, Automne}
}
