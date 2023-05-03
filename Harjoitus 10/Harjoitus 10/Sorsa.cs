using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    class Sorsa : Eläin, ICanSwim, ICanFly
    {
        public int UintiNopeus { get; set; }
        public float SiipiKoko { get; set; }

        public Sorsa(string _nimi, int uintiNopeus, float siipiKoko)
        {
            Nimi = _nimi;
            UintiNopeus = uintiNopeus;
            SiipiKoko = siipiKoko;
        }

        public void Lento()
        {
            Console.WriteLine("{0} lentää. Siipien koko on {1}", Nimi, SiipiKoko);
        }

        public override void TeeÄäni()
        {
            Console.WriteLine("quack");
        }

        public void Uinti()
        {
            Console.WriteLine("{0} ui nopeudella {1}", Nimi, UintiNopeus);
        }
    }
}
