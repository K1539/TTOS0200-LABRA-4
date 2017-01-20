/*
 * Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää perintää.
 *
 *Jere Liikka 20.1.2017 
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
            Kananmunat kananmunat = new Kananmunat(8, 3, "19.1.2017");
            Liha liha = new IT.Liha(5, 10, "possu");
            Maito maito = new IT.Maito(4, 4, "25.5.2017");
            Porkkanat porkkanat = new Porkkanat(20, 5, "Suomi");
            //
            Console.WriteLine("Kananmunat: ");            
            Console.WriteLine(kananmunat.ToString());
            Console.WriteLine("Ribsit: ");
            Console.WriteLine(liha.ToString());
            Console.WriteLine("Maito: ");
            Console.WriteLine(maito.ToString());
            Console.WriteLine("Porkkanat: ");
            Console.WriteLine(porkkanat.ToString());


        }
    }
}
