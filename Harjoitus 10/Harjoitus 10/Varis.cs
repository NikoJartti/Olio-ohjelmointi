using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    
        class Varis : Eläin, ICanFly
        {
            public float SiipiKoko { get; set; }

            public Varis(string _nimi, float _siipiKoko)
            {
                Nimi = _nimi;
                SiipiKoko = _siipiKoko;
            }
            public void Lento()
            {
                Console.WriteLine("{0} lentää. Siipien koko on {1}", Nimi, SiipiKoko);
            }

            public override void TeeÄäni()
            {
                Console.WriteLine("Kakaa");
            }


        }
}
