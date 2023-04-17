using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_3_kt
{
    internal class Kiuas
    {
        public string Valmistaja { get; set; }
        public int lämpötila { get; set; }
        public int kosteus { get; set; }
        public string päällä { get; set; }

        public Kiuas(string _Valmistaja, int _lämpötila, int _kosteus, string _päällä)
        {
            Valmistaja = _Valmistaja;
            lämpötila = _lämpötila;
            kosteus = _kosteus;
            päällä = _päällä;


        }

        public string TulostaData()
        {
            string KiuasTiedot = "Valmistaja " + Valmistaja + ". Lämpötila " + lämpötila + "°C. Kosteus " + kosteus.ToString() +"%. Päällä " + päällä.ToString();
            return KiuasTiedot;
        }

        public int MuokkaaLämpötilaa()
        {
            lämpötila = 110;
            return lämpötila;
        }
        public string Virta()
        {
            päällä = "kyllä";
            return päällä;
        }
    }
}
