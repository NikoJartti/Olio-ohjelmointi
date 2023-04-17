using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koira_olio
{
    internal class Koira
    {
        public string Nimi { get; set; }
        public string Rotu { get; set; }
        public int Ikä { get; set; }
        public string Väri { get; set; }
        public float Paino { get; set; }

        public Koira(string _nimi, string _rotu, int _ikä, string _väri, float _paino)
        {
            Nimi = _nimi;
            Rotu = _rotu;
            Ikä = _ikä;
            Väri = _väri;
            Paino = _paino;
        }

        public string HaeTiedot()
        {
            string KoiranTiedot = "Nimi " + Nimi + " Rotu " + Rotu + ". Ikä " + Ikä.ToString() + ". Väri " + Väri + ". Paino " + Paino.ToString();
            
            return KoiranTiedot;
        }
        public void Hauku()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
