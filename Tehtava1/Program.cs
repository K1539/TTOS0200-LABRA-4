/*
 * Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen liittyvä säädin. 
 * Toteutetun ohjelman tulee pystyä kysymään käyttäjältä haluttu kerros ja siirtämään hissi haluttuun kerrokseen 
 * (tässä tapauksessa ohjelma kertoo käyttäjälle missä kerroksessa hissi on). 
 * Muista, että Dynamon hissi voi olla vain kerroksissa 1-5. 
 * Käytä Hissi-luokassa get- ja set-aksessoreita suojamaan olion tila.

Esimerkkitoiminta:

 
    Elevator is now in floor : 1
    Give a new floor number (1-5) > 2
    Elevator is now in floor : 2
    Give a new floor number (1-5) > 3
    Elevator is now in floor : 3
    Give a new floor number (1-5) > 5
    Elevator is now in floor : 5
    Give a new floor number (1-5) > -1
    Floor is too small!
    Elevator is now in floor : 5
    Give a new floor number (1-5) > 6
    Floor is too big!
    Elevator is now in floor : 5
    Give a new floor number (1-5) > 2
    Elevator is now in floor : 2

    Jere Liikka 18.1.2016
    */
    
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
                Hissi hissi = new IT.Hissi();
                Console.Write("Give a new floor number (1-5) > ");
                hissi.Floor = int.Parse(Console.ReadLine());
                Console.WriteLine(hissi.Message + hissi.Floor);
            }
        }
    }
}