using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Bike : Vehicle
    {
        public bool VaihdePyora;
        public string VaihdeMalliNimi;


        public Bike()
        {

        }
        public Bike(string nimi, string malli, int vuosimalli, string vari, bool vaihdepyora, string vaihdemallinimi)
            : base(nimi, malli, vuosimalli, vari)
        {
            VaihdePyora = vaihdepyora;
            VaihdeMalliNimi = vaihdemallinimi;
        }
        public override string ToString()
        {
            return base.ToString() + "GearWheels: " + VaihdePyora + "Gear Name: " + VaihdeMalliNimi;
        }

    }
}
