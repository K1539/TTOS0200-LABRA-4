using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Kauppareissu
    {
        public int Kappaletta { get; set; }
        public int Hinta { get; set; }

        public Kauppareissu()
        {

        }
        public Kauppareissu(int kappaletta, int hinta)
        {
            Kappaletta = kappaletta;
            Hinta = hinta;
        }
        public override string ToString()
        {
            return "hinta: " + Hinta + " kappaletta: " + Kappaletta + " ";
        }
    }
}
