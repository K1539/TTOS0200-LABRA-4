using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class DVD : Parent
    {
        public string Type { get; set; }

        public DVD()
        {

        }
        public DVD(double price, int year, string type)
            : base (price, year)
        {
            Type = type;
        }
        public override string ToString()
        {
            return base.ToString() + " Type: " + Type;
        }



    }
}
