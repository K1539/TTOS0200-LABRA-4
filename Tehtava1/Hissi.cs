using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Hissi
    {
        private readonly int MaxFloor = 5;
        private readonly int MinFloor = 1;

        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value >= MaxFloor || value <= MinFloor)
                {

                    if (value >= MaxFloor)
                    {
                        Console.WriteLine("Too many floors");
                        floor = MaxFloor;
                    }
                    else
                    {
                        Console.WriteLine("No floors under 1");
                        floor = MinFloor;
                    }
                }
                else
                {
                    floor = value;
                }
            }
        }
        private string message;
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                if (floor >= MaxFloor || floor <= MinFloor)
                {

                    if (floor >= MaxFloor)
                    {
                        message = "No floors more than 5";
                    }
                    else
                    {
                        message = "No floors under 1";
                    }
                }
                else
                {
                    message = "";
                }
            }
        }
    }
}
