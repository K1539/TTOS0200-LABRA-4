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

        private int? floor;
        public int? Floor
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
                        floor = MaxFloor;
                    }
                    else
                    {
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
                if (floor >= MaxFloor || floor <= MinFloor)
                {

                    if (floor >= MaxFloor)
                    {
                        message = "Floor is too high";
                        floor = null;
                        return message;
                    }
                    else
                    {
                        message = "Floor is too high";
                        floor = null;
                        return message;
                    }
                }
                else
                {
                    message = "The elevator is in floor number ";
                    return message;
                }
            }
        }
    }
}
