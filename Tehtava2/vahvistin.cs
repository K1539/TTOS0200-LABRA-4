using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vahvistin
    {
        private readonly int MaxVol = 100;
        private readonly int MinVol = 0;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < MinVol || value > MaxVol)
                {
                    if (value > MaxVol)
                    {
                        volume = MaxVol;
                    }
                    else
                    {
                        volume = MinVol;
                    }
                }
                else
                {
                    volume = value;
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
                if (volume < MinVol || volume > MaxVol)
                {
                    if (volume > MaxVol)
                    {
                        message = "-> Too much volume -  Amplifier volume is set to maximum : ";
                    }
                    else
                    {
                        message = "-> Too low volume - Amplifier volume is set to minimum : ";
                    }
                }
                else
                {
                    message = "-> Amplifier volume is set to : ";
                }
            }
        }
    }
}
