using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Kananmunat : Kauppareissu
    {
        public string PakkausPVM { get; set; }

        public Kananmunat()
        {

        }
        public Kananmunat(int kappaletta, int hinta, string pakkauspvm)
            : base (kappaletta, hinta)
        {
            PakkausPVM = pakkauspvm;
        }

        public override string ToString()
        {
            return base.ToString() + "Tuote on pakattu " + PakkausPVM;
        }
    }
}
