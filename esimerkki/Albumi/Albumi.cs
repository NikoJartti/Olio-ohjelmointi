using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_4
{
    internal class Albumi
    {
        public string Artisti;
        public string AlbumiNimi;
        public string Genre;
        public int Hinta;

        private List<Kappale> Kappaleet = new List<Kappale>();

        public Albumi(string artisti, string albumiNimi, string genre, int hinta)
        {
            Artisti = artisti;
            AlbumiNimi = albumiNimi;
            Genre = genre;
            Hinta = hinta;
        }
        public void LisääKappale(Kappale kappale)
        {
            Kappaleet.Add(kappale);
        }
        public void TulostaKappaleet()
        {
            foreach (Kappale kappale in Kappaleet)
            {
                kappale.TulostaTiedot();
            }
        }

        public void TulostaAlbumi()
        {
            Console.WriteLine();
            Console.WriteLine("Albumi: ");
            Console.WriteLine(" Artisti - " + Artisti);
            Console.WriteLine(" Albumin nimi - " + AlbumiNimi );
            Console.WriteLine(" Genre - " + Genre);
            Console.WriteLine(" Hinta - " + Hinta);
            Console.WriteLine(" Kappaleet: ");
            TulostaKappaleet();
        }

    }
}
