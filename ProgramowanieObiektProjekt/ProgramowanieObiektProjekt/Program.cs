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

            Autobus bus1 = new Autobus(10,"ok","man",200, "rze",1, 1);
           
            Console.WriteLine("bus1");
            bus1.infoAutobus();

            Console.WriteLine("bus2");
            Autobus bus2 = new Autobus(10, "ok", "man", 200, "rze",2,2);
            bus2.ID = -10;
            bus2.Stan = "";
            bus2.Marka_model="";
            bus2.Rejestracja="";
            bus2.Miejsca=-200;
            bus2.BiletomatID = 5;
            bus2.infoAutobus();

            Console.WriteLine("bus3");
            Autobus bus3 = new Autobus(10,"ok","man",200, "rze",12,3);
            bus3.editAutobus("nieOk","mercedes",100,"wa",3);
            bus3.infoAutobus();


            Biletomat bil1 = new Biletomat(1,"s","s");
            bil1.infoBiletomat();
            bil1.editBiletomat( "XD","ok" );
            bil1.infoBiletomat();


            kierowca kie1 = new kierowca(1, "Bolesław", "Wadzinski");
            kie1.infoKierowca();
            kie1.editKierowca("maciej", "stary");
            kie1.infoKierowca();



            Console.ReadKey();
        }

    }

}
