using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Maito : Kauppareissu
    {
        public string ParastaEnnen { get; set; }

        public Maito()
        {

        }
        public Maito(int kappaletta, int hinta, string parastaennen)
            : base (kappaletta, hinta)
        {
            ParastaEnnen = parastaennen;
        }

        public override string ToString()
        {
            return base.ToString() + "Parasta ennen: " + ParastaEnnen;
        }
    }
}
