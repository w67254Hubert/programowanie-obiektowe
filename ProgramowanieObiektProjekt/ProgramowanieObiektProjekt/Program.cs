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

            Autobus elo = new Autobus();

            Console.WriteLine(elo.marka_model);

            //elo.setMiejsca(100);

            //Console.WriteLine(elo.getMiejsca());
            elo.Miejsca = 20;
            elo.Miejsca = -20;

            Console.WriteLine(elo.Miejsca);

            Autobus elo2 = new Autobus( "ok", "Merc");

            Console.WriteLine(elo2.marka_model);
     


            Console.ReadKey();
        }
        

    }

}
