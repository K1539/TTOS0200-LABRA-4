using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Papers : Parent
    {
        public string PaperName;

        public Papers()
        {

        }
        public Papers(double price, int year, string papername)
            : base (price, year)
        {
            PaperName = papername;
        }

        public override string ToString()
        {
            return base.ToString() + " Name: " + PaperName;
        }
    }
}
