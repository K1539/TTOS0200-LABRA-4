/*
 * Tehtävänäsi on ohjelmoida yksinkertaisen vahvistimen toiminta, jolla voidaan kontrolloida äänenvoimakkuutta välillä 0-100. 
 * Toteuta Vahvistin-luokka ja tee pääohjelma, jolla luot olion Vahvistin-luokasta. Säädä ja kokeile vahvistinta eri äänenvoimakkuuksilla. 
 * Käytä Vahvistin-luokassa get- ja set-aksessoreita. get-aksessori palauttaa äänenvoimakkuuden ja set-aksessori rajaa äänenvoimakkuuden arvoa.

Esimerkkitoiminta:

    
    Give a new volume value (0-100) > 100
    -> Amplifier volume is set to : 100
    Give a new volume value (0-100) > 40
    -> Amplifier volume is set to : 40
    Give a new volume value (0-100) > 0
    -> Amplifier volume is set to : 0
    Give a new volume value (0-100) > -10
    -> Too low volume - Amplifier volume is set to minimum : 0
    Give a new volume value (0-100) > 200
    -> Too much volume -  Amplifier volume is set to maximum : 100
    Give a new volume value (0-100) > 35
    -> Amplifier volume is set to : 35
    *
    * jere Liikka 18.1.2017
    * */
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
            while (true)
            {
                Vahvistin vahvistin = new Vahvistin();
                Console.Write(" Give a new volume value (0-100) > ");
                vahvistin.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine(vahvistin.Message + vahvistin.Volume);
            }
        }
    }
}
