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
        public Autobus(int kid, string kstan, string kmarka_model, int kmiejsca, string krejestracja)
        {
            Console.WriteLine("konstruktor wymuszanie podania wartości");
            ID = kid;
            Stan = kstan;
            Marka_model = kmarka_model;
            Rejestracja = krejestracja;
            Miejsca = kmiejsca;
        }
        

        private int id;
        private string stan;
        private string marka_model;
        private string rejestracja;
        private int miejsca;


       public int Miejsca
        {
            get { return miejsca; }
            set
            {
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

        public string Rejestracja
        {
            get { return rejestracja; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                     rejestracja =value ;

                }
                else
                {
                    rejestracja = "brakrejestracji";

                }
            }
        }
        public string Marka_model
        {
            get { return marka_model; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    marka_model = value;
                }
                else
                {
                    marka_model = "brak marki i modelu";

                }
            }
        }

        public string Stan
        {
            get { return stan; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    stan = value;
                }
                else
                {
                    stan = "Nie znany stan";

                }
            }
        }

        public int ID
        {
            get { return id; }
            set
            {
                if (value >= 0)
                {
                    id = value;
                }
                else
                {
                    id = 0;
                }
            }
        }


        ~Autobus()
        {
            Console.Write("destruktor");

        }
    }
}
