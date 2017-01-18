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
                        value = MaxVol;
                    }
                    else
                    {
                        value = MinVol;
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

        }
    }
}
