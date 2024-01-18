using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ta według tej klasy mamy obiekt autobus metody opisują autobus
namespace ProgramowanieObiektProjekt
{
    class Autobus
    {
        public Autobus(string Stank, string Marka_modelK)
        {   //może być wiele konstruktorów ten wymaga podania imienia podczas wywołania
            Console.WriteLine("konstruktor wymuszanie podania wartości");
            Stan = Stank;
            marka_model = Marka_modelK;
        }

        public Autobus()
        {   //trn nie potrzebuje niczego podczas wywołania 
            Console.WriteLine("konstruktor wymuszanie podania wartości");

        }
        public string Stan = "nie ma danych";
        public string marka_model = "nie ma marki";
        public string rejestracja = "brak rejestracji";

        // public int getMiejsca()
        // {
        //     return miejsca;
        //}
        // public void setMiejsca(int w)
        // {
        //     if (0>w)
        //     {
        //         miejsca = w;
        //     }
        // }
 //propfull
        private int miejsca;

        public int Miejsca
        {
            get { return miejsca; }
            set {
                if (value >= 0)
                {
                    miejsca = value;
                }
                else
                {
                    miejsca = 0;
                }
            }
            

        }
        public string cos { get; set; } 

        ~Autobus()
        {
            Console.Write("destruktor");

        }
    }
}
