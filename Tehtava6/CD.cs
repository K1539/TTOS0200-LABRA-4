using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class CD : Parent
    {
        public string Type;

        public CD()
        {

        }
        public CD(double price, int year, string type)
            : base(price, year)
        {
            Type = type;
        }

        public override string ToString()
        {
            return base.ToString() + " Type: " + Type;
        }
    }
}
