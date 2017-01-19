using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Radio
    {
        double taajuus;
        public bool OnOff;
        int volume;
        private double MaxTaajuus = 26000.0;
        private double MinTaajuus = 2000.0;
        private int MaxVol = 9;
        private int MinVol = 0;
        public double Taajuus
        {
            get
            {
                return taajuus;
            }
            set
            {
                if (value > MaxTaajuus || value < MinTaajuus)
                {
                    if (value > MaxTaajuus)
                    {
                        taajuus = MaxTaajuus;
                        
                    }
                    else
                    {
                        taajuus = MinTaajuus;
                    }
                }
                else { taajuus = value; }
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > MaxVol || value < MinVol)
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
    }
}
