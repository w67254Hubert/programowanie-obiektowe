using System;
using System.Reflection.Metadata;
//aplikacja transportu miejskiego do sprawdzania posiadanych autobusów

namespace Projekt
{
    class Program
    {
        static void Main(string[] args) {
            Autobusy.Autobus elo = new Autobusy.Autobus();
            Console.WriteLine(elo.marka_model); 
        }
        

    }

}
