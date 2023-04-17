using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    internal class Auto
    {
        public string Nimi { get; set; }
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }





        public string TulostaData()
        {
            string AutonTiedot = "Nimi: " + Nimi + ", Nopeus: " + Nopeus.ToString() + " km/h, Renkaat: " + Renkaat.ToString();

            return AutonTiedot;
        }
    }
}
