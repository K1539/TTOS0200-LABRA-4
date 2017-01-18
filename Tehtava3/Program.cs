/*
 * Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee). 
 * Työntekijöiden osalta seuraavia tietoa pitää pystyä käsittelemään: työntekijän nimi (Name), työntekijän ammatti (Profession) ja palkka (Salary). 
 * Samassa ohjelmassa pitää pystyä käsittelemään myös johtajien tietoja (Boss), heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus).

Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot. 
Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta. 
Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan. 
Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.

Esimerkkitoiminta: (huomaa, että Kirsi Kernelin tietoja on muutettu ohjelman suorituksessa)


    Employee:
    - Name:Kirsi Kernel Profession:Teacher Salary:1200
    
    Boss:
    - Name:Jussi Jurkka Profession:Head of Institute Salary:9000 Car:Audi Bonus:5000
    
    Employee:
    - Name:Kirsi Kernel Profession:Principal Teacher Salary:2200

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
        static void Main()
        {

        }
        static void Persons()
        {
            Boss boss1 = new Boss();
            boss1.Name = "Jussi Jurkka";
            boss1.Profession = "head of institute";
            boss1.Salary = 9000;
            boss1.Car = "Audi";
            boss1.bonus = 5000;

            Employee employee1 = new Employee();
            employee1.Name = "Kirsi kernel";
            employee1.Profession = "Teacher";
            employee1.Salary = 1200;

        }
    }
}
