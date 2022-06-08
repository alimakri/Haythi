using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammifere vache = new Mammifere();
            vache.Allaiter();
            vache.Cri = "Meuglement";

            Oiseau pie = new Oiseau();
            pie.Pondre();
            pie.Cri = "Jacassement";

        }
    }
    class Animal
    {
        public bool IsCoeur=true;
        public int NYeux = 2;
        public string Cri;
        public void Respirer() { }
    }
    class Mammifere : Animal
    {
        public void Allaiter() { }
    }
    class Oiseau : Animal
    {
        public string Plumage;
        public void Pondre() { }
    }
    class Aliment
    {

    }
}
