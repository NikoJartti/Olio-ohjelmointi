using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_4
{
    internal class Kappale
    {
        private string Nimi;
        private string Kesto;
        
        public Kappale(string nimi, string kesto)
        {
            Nimi = nimi;
            Kesto = kesto;
        }
        public void TulostaTiedot()
        {
            Console.WriteLine(" -" + Nimi + " - " + Kesto + " minuuttia");
        }
    }
}
