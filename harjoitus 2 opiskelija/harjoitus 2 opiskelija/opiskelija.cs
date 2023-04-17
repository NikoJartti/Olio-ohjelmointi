using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_2_opiskelija
{
    internal class opiskelija
    {
        public string Nimi { get; set; }
        public string OpiskelijaID { get; set; }
        public int Opintopisteet { get; set; }

        public opiskelija(string _Nimi, string _OpiskelijaID, int _Opintopisteet)
        {
            Nimi = _Nimi;
            OpiskelijaID = _OpiskelijaID;
            Opintopisteet = _Opintopisteet;           
        }

        public string TulostaData()
        {
            string OpiskelijaTiedot = "Nimi " + Nimi + ". OpiskelijaID " + OpiskelijaID + ". Opintopisteet " + Opintopisteet.ToString();
            return OpiskelijaTiedot;
        }

        public int MuokkaaOpintopisteita()
        {
            Opintopisteet = 10;
            Console.WriteLine("Opintopisteiden määrä muokattu: " + Opintopisteet);
            return Opintopisteet;
        }
    }
}
