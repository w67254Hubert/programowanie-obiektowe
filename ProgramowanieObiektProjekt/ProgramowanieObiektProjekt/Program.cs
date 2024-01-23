using System;
using System.Reflection.Metadata;
//aplikacja transportu miejskiego do sprawdzania posiadanych autobusów
//ogarnij enum
//try cath do obsługi bazy danych 

namespace ProgramowanieObiektProjekt
{
    class Program
    {
        static void Main(string[] args) {

            Autobus bus1 = new Autobus(10,"ok","man",200, "rze");
           
            Console.WriteLine("bus1");

            Console.WriteLine(bus1.ID);
            Console.WriteLine(bus1.Stan);
            Console.WriteLine(bus1.Marka_model);
            Console.WriteLine(bus1.Rejestracja);
            Console.WriteLine(bus1.Miejsca);

            Console.WriteLine("bus2");
            Autobus bus2 = new Autobus(10, "ok", "man", 200, "rze");
            bus2.ID = -10;
            bus2.Stan = "";
            bus2.Marka_model="";
            bus2.Rejestracja="";
            bus2.Miejsca=-200;
            Console.WriteLine(bus2.ID);
            Console.WriteLine(bus2.Stan);
            Console.WriteLine(bus2.Marka_model);
            Console.WriteLine(bus2.Rejestracja);
            Console.WriteLine(bus2.Miejsca);

            Console.WriteLine("bus3");

            Autobus bus3 = new Autobus(10,"ok","man",200, "rze");
            string CoWObiekt(bus3);

            Console.ReadKey();
        }
        

    }

}
