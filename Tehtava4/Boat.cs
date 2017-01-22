using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Boat : Vehicle
    {
        public string VeneenTyyppi;
        public int IstumaPaikkoja;

        public Boat()
        {

        }
        public Boat(string nimi, string malli, int vuosimalli, string vari, int istumapaikkoja, string veneentyyppi)
            : base(nimi, malli, vuosimalli, vari)
        {
            IstumaPaikkoja = istumapaikkoja;
            VeneenTyyppi = veneentyyppi;
        }

        public override string ToString()
        {
            return base.ToString() + " SeatCount: " + IstumaPaikkoja + " BoatType: " + VeneenTyyppi;
        }
    }
}
