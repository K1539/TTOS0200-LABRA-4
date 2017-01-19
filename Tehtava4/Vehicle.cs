using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Vehicle
    {
        private string Name { get; set; }
        private string Model { get; set; }
        private int ModelYear { get; set; }
        private string Color { get; set; }

        public Vehicle(string name, string mdl, int year, string clr)
        {
            Name = name;
            Model = mdl;
            ModelYear = year;
            Color = clr;
        }

        public override string ToString()
        {
            return "- Name: " + Name + ". Model: " + Model + ". Model Year: " + ModelYear + ". Color: " + Color;
        }
    }
}
