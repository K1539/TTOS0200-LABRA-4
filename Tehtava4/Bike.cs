using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Bike : Vehicle
    {
        private bool GearWheels { get; set; }
        private string GearType { get; set; }

        public Bike(string name, string mdl, int year, string clr, bool gearwheels, string type)
            : base(name, mdl, year, clr)
        {
            GearWheels = gearwheels;
            GearType = "";
        }
        public Bike(string name, string mdl, int year, string clr, bool gearwheels)
             : base(name, mdl, year, clr)
        {
            GearWheels = gearwheels;
            GearType = "";
        }

        public override string ToString()
        {
            return "Bike: \n" + base.ToString() + ". Gear Wheels: " + GearWheels + ". Gear Name: " + GearType;
        }
    }
}
