using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new IT.Hissi();
            hissi.Floor = 6;
            Console.WriteLine("The elevator is in floor number " + hissi.Floor);
        }
    }
}