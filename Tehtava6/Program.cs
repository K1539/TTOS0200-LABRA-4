/*
 * ICT-opiskelijan kirjahyllystä löytyy vaikka mitä erilaisia tavaroita: 
 * kirjoja, lehtiä, cd-levyjä, dvd-levyjä, bluray-levyjä, puhelimia, tabletteja, läppäreitä, ... jne. 
 * Pohdi UML-kaaviota käyttäen millaisia luokkarakenteita (ainakin luokkien ja ominaisuuksien osalta) esiintyy ja käytä apua perintää, 
 * jos tavaroille löytyy yhteisiä ominaisuuksia. 
 * Toteuta tämän jälkeen muutamia luokkia, joissa perintää esiintyy. Tee myös pääohjelma, jossa käytät tekemiäsi luokkia ja luot olioita.
 * 
 * Jere Liikka 19.1.2017
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
            BluRay bluray = new BluRay(20, 2010, "Animation");
            Books books = new Books(10, 2006, 222);
            CD cd = new CD(15, 1996, "Rock");
            DVD dvd = new DVD(19, 2007, "Comedy");
            Papers papers = new Papers(5, 2016, "Donald Duck");
                        //
            Console.WriteLine(bluray.ToString());
            Console.WriteLine(books.ToString());
            Console.WriteLine(cd.ToString());
            Console.WriteLine(dvd.ToString());
            Console.WriteLine(papers.ToString());
        }
    }
}
