using System;
using System.Reflection.Metadata;
//aplikacja transportu miejskiego do sprawdzania posiadanych autobusów

namespace Projekt
{
    class Program
    {
        static void Main(string[] args) {

            Autobus elo = new Autobus();

            Console.WriteLine(elo.marka_model);


            Autobus elo2 = new Autobus( "ok", "Merc");

            Console.WriteLine(elo2.marka_model);



            Console.ReadKey();
        }
        

    }

}
