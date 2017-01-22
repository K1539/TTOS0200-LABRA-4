using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Porkkanat : Kauppareissu
    {
        public string Alkuperaismaa { get; set; }

        public Porkkanat()
        {

        }
        public Porkkanat(int kappaletta, int hinta, string alkuperaismaa)
            : base (kappaletta, hinta)
        {
            Alkuperaismaa = alkuperaismaa;
        }

        public override string ToString()
        {
            return base.ToString() + "Alkuperämaa: " + Alkuperaismaa;
        }
    }
}
