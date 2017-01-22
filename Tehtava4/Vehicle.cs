using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JAMK.IT
{
    public class Vehicle
    {
        public string Nimi;
        public string Malli;
        public int Vuosimalli;
        public string Vari;

        public Vehicle()
        {

        }
        public Vehicle(string nimi, string malli, int vuosimalli, string vari)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosimalli = vuosimalli;
            Vari = vari;
        }
        public override string ToString()
        {
            return "- Name: " + Nimi + " Model: " + Malli + " ModelYear: " + Vuosimalli + "Color: " + Vari;
        }
    }
}
