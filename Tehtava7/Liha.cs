using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Liha : Kauppareissu
    {
        public string MinkaElaimenLiha { get; set; }

        public Liha()
        {

        }
        public Liha(int kappaletta, int hinta, string minkaelaimenliha)
            : base (kappaletta, hinta)
        {
            MinkaElaimenLiha = minkaelaimenliha;
        }
        
        public override string ToString()
        {
            return base.ToString() + "Liha on " + MinkaElaimenLiha + "n lihaa";
        }

    }
}
