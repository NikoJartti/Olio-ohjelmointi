using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläimet
{
    class Eläin
    {
        static int instanssit = 0;

        public Eläin()
        {
            instanssit++;
        }

        public static int MontaEläintä()
        {
            return instanssit;
        }

        public virtual string Ääni()
        {
            return "Eläin ääntelee";
        }
    }
}
