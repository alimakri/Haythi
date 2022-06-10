using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var pc1 = new Ordinateur();
            pc1.AdresseIp = "192.168.1.a";
            //pc1.SetAdresseIp("abc");
            var ip1 = pc1.AdresseIp;
            //var ip1 = pc1.GetAdresseIp();

            var c = new Class1 { p1 = 1, p2 = 2 };
            Console.WriteLine("Salam");
            Console.Read();
        }
    }
    partial class Class1
    {
        public int p2;
    }

}
namespace espace1
{
    partial class Class1
    {
        public int p2;
    }
}