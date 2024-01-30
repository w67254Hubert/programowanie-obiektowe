using System;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using ProgramowanieObiektProjekt.klasy;
//aplikacja transportu miejskiego do sprawdzania posiadanych autobusów
//podłącz sqla bazze i z niej pobierz wartości do obiektóws


namespace ProgramowanieObiektProjekt
{
    class Program
    {
        static void Main(string[] args) {

            Autobus bus1 = new Autobus(1,"ok","man",100, "",3,42);

            Autobus bus2 = new Autobus(2, "nieOk", "man", 1000, "", 2, 25);

            Autobus bus3 = new Autobus(3, "ok", "man", 200, "rze", 1, 13);

            Biletomat bil1 = new Biletomat(1,"bmat","ok");

            Biletomat bil2 = new Biletomat(2, "bmat", "ok");

            Biletomat bil3 = new Biletomat(3, "bmat", "ok");

            kierowca kie1 = new kierowca(5, "Bolesław", "Wadzinski");

            kierowca kie2 = new kierowca(6, "Bolesław", "wadzinski");

            kierowca kie3 = new kierowca(7, "hubert", "Lania");

            while (true)
            {
                Console.WriteLine(">>>>>>>MENU<<<<<<<<");
                Console.WriteLine("1-informacje o zawartości obiektów");
                Console.WriteLine("2-informacje o zaktualizuj obiekty");
                Console.WriteLine("3-Odświerz widok konsoli");
                Console.WriteLine("4-Zakończdziałanie");

                string x = Console.ReadLine();
                int.TryParse(x, out int w);

                if (w == 1)
                {   
                    Console.WriteLine("Autobusy");
                    bus1.infoAutobus();
                    bus2.infoAutobus();
                    bus3.infoAutobus();

                    Console.WriteLine("biletomaty");
                    bil1.infoBiletomat();
                    bil2.infoBiletomat();
                    bil3.infoBiletomat();

                    Console.WriteLine("bierowcy");
                    kie1.infoKierowca();
                    kie2.infoKierowca();
                    kie3.infoKierowca();
                }
                if (w == 2)
                {

                    bus1.editAutobus("nieOk", "mercedes", -110, "RZE12345", 3, 4);
                    bus2.editAutobus("Ok", "", 100, "RZE1231", 2, 5);
                    bus3.editAutobus("nieOk", "mercedes", 100, "RZE1212", 1, 6);

                    bil1.editBiletomat("bmat+", "ok");
                    bil2.editBiletomat("bmat++", "ok");
                    bil3.editBiletomat("", "nieOk");

                    kie1.editKierowca("Maciej", "Stary");
                    kie2.editKierowca("", "Wadzinski");
                    kie3.editKierowca("Hubert", "Łania");

                    Console.WriteLine("Aktualizacja powiodła się");
                }
                if (w == 3)
                {
                    Console.Clear();
                }

                if (w==4)
                {
                    break;
                }

            }
            Console.ReadKey();
        }

    }

}
