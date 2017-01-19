/*
 * ehtävässä tulee toteuttaa C#-ohjelma radion perustoimintojen testaamiseen.

Kannettavassa radiossa on vain kolme säädintä: päälle/pois-kytkin, äänen voimakkuuden säädin (arvot 0, 1, 2,..., 9) ja kuunneltavan kanavan taajuusvalinta (2000.0 - 26000.0).
Laadi luokka kannettavan radion toteutukseksi. Käytä tekemääsi luokkaa pääohjelmasta käsin, eli testaile radion toimivuutta erilaisilla voimakkuuden ja taajuuden arvoilla. 
Jätä asetus- ja tulostuslauseet näkyville pääohjelmaan, jotta radio-olion käyttö voidaan todentaa.

Jere Liikka 19.1.2017
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using JAMK.IT;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string radioSetOnOff;
                Radio radio = new IT.Radio();
                Console.Write("Turn radio on? yes / no > ");
                radioSetOnOff = Console.ReadLine();
                switch (radioSetOnOff)
                {
                    case "yes":
                        radio.OnOff = true;
                        break;
                    case "no":
                        radio.OnOff = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choise, turning radio off.");
                        break;
                }
                if (radioSetOnOff == "no")
                {
                    Console.WriteLine("The Radio has been turned off for this session.");
                    break;
                }
                if (radio.OnOff == true)
                {
                    Console.Write("Set the radio frequency (2000.0 - 26000.0 > ");
                    radio.Taajuus = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                    //
                    Console.Write("Set the radio volume (1 - 9) > ");
                    radio.Volume = int.Parse(Console.ReadLine());
                    //
                    Console.WriteLine("Radio is turned on: " + radio.OnOff);
                    Console.WriteLine("The chosen frequency " + radio.Taajuus);
                    Console.WriteLine("Volume: " + radio.Volume);
                }
                else
                {
                    Console.WriteLine("Radio is turned off. No point asking any more questions.");
                }

            }
        }
    }
}
