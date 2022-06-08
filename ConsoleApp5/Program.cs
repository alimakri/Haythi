using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Partie p = new Partie();
            p.Init();
            bool fin = false;

            while (!fin)
            {
                Console.WriteLine("Donner un nombre compris entre 1 et 99");
                p.NombrePropose = int.Parse(Console.ReadLine());
                p.NCoup++;
                p.Comparer();
                switch (p.Reponse)
                {
                    case ReponseEnum.TropPetit:
                        Console.WriteLine("Trop petit");
                        break;
                    case ReponseEnum.TropGrand:
                        Console.WriteLine("Trop grand");
                        break;
                    case ReponseEnum.Gagne:
                        Console.WriteLine("Gagné");
                        fin = true;
                        break;
                    case ReponseEnum.Perdu:
                        Console.WriteLine("Perdu");
                        fin = true;
                        break;
                }
            }
            Console.Read();
        }
    }
    class Partie
    {
        public Random Alea = new Random();
        public void Init()
        {
            NombreADeviner = Alea.Next(1, 100);
            NCoup = 0;
            MaxCoup = 7;
        }
        public int NombreADeviner = 0;
        public int NombrePropose;
        public int MaxCoup = 7;
        public int NCoup = 7;
        public ReponseEnum Reponse;
        public void Comparer()
        {
            if (NCoup > MaxCoup)
                Reponse = ReponseEnum.Perdu;
            else if (NombrePropose > NombreADeviner)
                Reponse = ReponseEnum.TropGrand;
            else if (NombrePropose < NombreADeviner)
                Reponse = ReponseEnum.TropPetit;
            else Reponse = ReponseEnum.Gagne;
        }

    }
    enum ReponseEnum { TropPetit, TropGrand, Gagne, Perdu }
}
