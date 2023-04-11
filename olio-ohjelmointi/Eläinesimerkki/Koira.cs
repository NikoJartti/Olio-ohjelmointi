using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläinesimerkki
{
    internal class Koira
    {
        public string Nimi { get; set; }
        public string Rotu { get; set; }
        public int Ikä { get; set; }
        public string Väri { get; set; }
        public float Paino { get; set;}

        public string HaeTiedot()
        {
            string KoiranTiedot = "Nimi: " + Nimi + ". Rotu " + Rotu + ". ikä " + Ikä.ToString() + ". Väri " + Väri + ". Paino " + Paino.ToString();

            return KoiranTiedot;
        }
        public void Hauku()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
