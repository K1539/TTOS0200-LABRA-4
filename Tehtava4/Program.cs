/*
 * oteutettavassa sovelluksessa tulisi pysyä käsittelemään erilaisia kulkuneuvoja.
 *  Kaikilla kulkuneuvoilla on löydettävissä yhteisinä ominaisuuksina: nimi, malli, vuosimalli ja väri. 
 *  Erikoistapauksina pitää pystyä käsittelemään polkupyöriä ja veneitä.
 *   Polkupyörän osalta pitää pystyä erottelemaan se, että onko kyseessä vaihdepyörä vai ei sekä mahdollisen vaihteiston mallinimi. 
 *   Veneiden osalta tietoina pitää ainakin olla veneen tyyppi (soutuvene, moottorivene, kajakki, ...) ja kuinka monta istuinpaikkaa veneestä löytyy.

Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot. 
Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta. 
Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan. 
Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.

Esimerkkitoiminta:


    Bike info 
    - Name:Jopo Model:Street ModelYear:2016 Color:Blue GearWheels:False Gear Name:
    
    Bike2 info 
    - Name:Tunturi Model:StreetPower ModelYear:2010 Color:Black GearWheels:True Gear Name:Shimano
    
    Boat info 
    - Name:Suvi Model:S900 ModelYear:1990 Color:White SeatCount:3 BoatType:Rowboat
    
    Boat2 info 
    - Name:Yamaha Model:Model 1000 ModelYear:2010 Color:Yellow SeatCount:5 BoatType:Motorboat

    Jere Liikka 18.1.2017
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
            Bike bike = new Bike("Jopo", "Street", 2016, "Blue", false);
            Bike bike2 = new Bike("Tunturi", "StreetPower", 2010, "Black", true, "Shimano");
            Boat boat = new Boat("Suvi", "S900", 1990, "White", 3, "Row Boat");
            Boat boat2 = new Boat("Yamaha", "1000", 2010, "Yellow", 5, "Motorboat");
            Console.WriteLine(bike.ToString());
            Console.WriteLine(bike2.ToString());
            Console.WriteLine(boat.ToString());
            Console.WriteLine(boat2.ToString());
        }
    }
}
