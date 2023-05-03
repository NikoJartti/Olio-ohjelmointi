using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    interface ICanSwim
    {
        public int UintiNopeus { get; set; }

        public void Uinti();
    }
}
