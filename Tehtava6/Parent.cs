using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Parent
    {
        public double Price { get; set; }
        public int Year { get; set; }

        public Parent()
        {
            
        }
        public Parent(double price, int year)
        {
            Price = price;
            Year = year;
        }
        public override string ToString()
        {
            return "Price: " + Price + " Year: " + Year;
        }
    }
}
