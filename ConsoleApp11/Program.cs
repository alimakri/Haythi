using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// XYZ
namespace ConsoleApp11
{
    delegate void RefroidirDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Centrale c1 = new Centrale();
            c1.RefroidirNoyau();
        }
    }
    class Centrale
    {
        //public ArrayList Pompes = new ArrayList();
        public List<RefroidirDelegate> Delegues = new List<RefroidirDelegate>();

        public Centrale()
        {
            var p1 = new PompeElectrique();
            var p2 = new PompeElectrique();
            var p3 = new PompeHydraulique();
            var p4 = new PompeManuelle();

            var d1 = new RefroidirDelegate(p1.Refroidir);
            var d2= new RefroidirDelegate(p2.Refroidir);
            var d3 = new RefroidirDelegate(p3.Refroidir);
            var d4 = new RefroidirDelegate(p4.Refroidir);

            //Pompes.Add(p1);
            //Pompes.Add(p2);
            //Pompes.Add(p3);

            Delegues.Add(d1);
            Delegues.Add(d2);
            Delegues.Add(d3);
            Delegues.Add(d4);
        }
        public void RefroidirNoyau()
        {
            //foreach (var p in Pompes)
            //{
            //    if (p is PompeHydraulique) ((PompeHydraulique)p).Refroidir();
            //    else if (p is PompeElectrique) ((PompeElectrique)p).Refroidir();
            //}

            foreach(var d in Delegues)
            {
                d.Invoke();
            }
        }
    }
    class PompeElectrique
    {
        public void Refroidir()
        {
            Console.WriteLine("Pompe electrique lancée");
        }
    }
    class PompeHydraulique
    {
        public void Refroidir()
        {
            Console.WriteLine("Pompe hydraulique lancée");
        }
    }
    class PompeManuelle
    {
        public void Refroidir()
        {
            Console.WriteLine("Pompe manuelle lancée");
        }
    }
}
