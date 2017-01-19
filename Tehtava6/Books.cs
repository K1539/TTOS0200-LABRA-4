using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Books : Parent
    {
        public int Pages { get; set; }

        public Books()
        {

        }
        public Books(double price, int year, int pages)
            : base(price, year)
        {
            Pages = pages;
        }
        public override string ToString()
        {
            return base.ToString() + " Pages: " + Pages;
        }
    }
}
