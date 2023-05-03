using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    internal class Kanava
    {
        public string nimi;
        List<double> taajudet = new List<double>();

        public string nimi;

        public float taajuus
        {
            get { return taajuus; }

            set
            {
                if (value < 88.0f)
                {
                    Console.WriteLine("Annoit taajudeksi liian pienen arvon " + value);
                    Console.WriteLine("Tarkista antamasi taajuus " + value);

                }
                else if (value > 107.9f)
                {
                    Console.WriteLine("Annoit taajudeksi liian suuren arvon " + value);
                    Console.WriteLine("Tarkista antamasi taajuus " + value);
                }
                else
                {
                    if (taajudet.Contains(value))
                    {

                        Console.WriteLine("Taajus on jo käytössä. Valitse uusi taajuus.");


                    }
                    else
                    {
                        taajudet.Add(value);

                        taajuus = value;


                        Console.WriteLine("Annoit taajudeksi arvon " + taajuus);
                        Console.WriteLine("Taajus on asetettu " + taajuus);

                    }
                }
            }
        }
    }
}
