using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Ordinateur
    {
        //private string AdresseIp;
        //public void SetAdresseIp(string ip)
        //{
        //    AdresseIp = ip;
        //}
        //public string GetAdresseIp()
        //{
        //    return AdresseIp;
        //}


        public string AdresseIp
        {
            get { return adresseIp; }
            set
            {
                var tab = value.Split('.');
                if (tab.Length != 4) return;
                int x = 0;
                foreach (var n in tab)
                {
                    if (!int.TryParse(n, out x) || x < 0 || x > 255) return;
                }

                adresseIp = value;
            }
        }
        private string adresseIp;

    }
    partial class Class1
    {
        public int p1;
    }
}
