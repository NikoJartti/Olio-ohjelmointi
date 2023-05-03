using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_7
{
    internal class Hissi
    {
        private int kerros;

        public Hissi()
        {
            kerros = 1;
        }

        public int Kerros
        {
            get { return kerros; }
            set
            {
                if (value >= 1 && value <= 6)
                {
                    kerros = value;
                    Console.WriteLine("Hissi on nyt kerroksessa: " + kerros);
                }
                else
                {
                    Console.WriteLine("Error: Virheellinen kerros!");
                }
            }
        }
    }
}
