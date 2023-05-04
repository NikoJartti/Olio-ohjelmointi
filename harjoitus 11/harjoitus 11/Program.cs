using harjoitus_11;
using System;

namespace Harjoitus_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string lukija = "";

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Anna komento (Näytä, Lisää, Poista tai Poistu) > ");
                lukija = Console.ReadLine().ToLower();

                switch (lukija)
                {
                    case "näytä":
                        KokoelmaManageri.TulostaKokoelma();
                        break;
                    case "lisää":
                        Lisää();
                        break;
                    case "poista":
                        Poista();
                        break;
                    case "poistu":
                        Console.WriteLine("Poistutaan sovelluksesta");
                        return;
                    default:
                        Console.WriteLine("Virheellinen syöttö, yritä uudelleen");
                        break;
                }
            }
        }

        static void Lisää()
        {
            string etunimi = "";
            string sukunimi = "";

            Console.WriteLine();
            Console.WriteLine("Anna uuden Opiskelijan tiedot: ");
            Console.WriteLine();

            Console.Write("Etunimi: ");
            etunimi = Console.ReadLine();

            Console.Write("Sukunimi: ");
            sukunimi = Console.ReadLine();

            KokoelmaManageri.LisääOpiskelija(etunimi, sukunimi);
        }

        static void Poista()
        {
            if (KokoelmaManageri.Opiskelijat.Count == 0)
            {
                Console.WriteLine("Opiskelija kokoelma on tyhjä!");
                return;
            }

            KokoelmaManageri.TulostaKokoelma();

            int indeksi;
            int opiskelijaMäärä = KokoelmaManageri.Opiskelijat.Count;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Kenet haluat poistaa? Valitse väliltä {0} - {1} > ", 1, opiskelijaMäärä);

                bool result = int.TryParse(Console.ReadLine(), out indeksi);

                if (result)
                {
                    if (indeksi <= opiskelijaMäärä && indeksi > 0)
                    {
                        KokoelmaManageri.PoistaOpiskelija(indeksi - 1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Virheellinen valinta!");
                    }
                }
                else
                {
                    Console.WriteLine("Syötöksi kelpaa vain numerot!");
                }
            }
        }
    }
}