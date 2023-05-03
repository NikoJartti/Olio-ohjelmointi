using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    class Kala : Eläin, ICanSwim
    {
        public int UintiNopeus { get; set; }
        public string Ääni { get; set; }

        public Kala(string _nimi, int nopeus, string ääni)
        {
            Nimi = _nimi;
            UintiNopeus = nopeus;
            Ääni = ääni;
        }
        public override void TeeÄäni()
        {
            Console.WriteLine(Ääni);
        }

        public void Uinti()
        {
            Console.WriteLine("Kala {0} ui nopeudella {1}", Nimi, UintiNopeus);
        }
    }
}
