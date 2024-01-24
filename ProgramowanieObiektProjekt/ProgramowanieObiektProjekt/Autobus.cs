using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ta według tej klasy mamy obiekt autobus metody opisują autobus
namespace ProgramowanieObiektProjekt
{
    public class Autobus
    {
        public Autobus(int kid, string kstan, string kmarka_model, int kmiejsca, string krejestracja,int kbiletomatID)
        {
            ID = kid;
            Stan = kstan;
            Marka_model = kmarka_model;
            Rejestracja = krejestracja;
            Miejsca = kmiejsca;
            biletomatID = kbiletomatID;
        }
        

        private int id;
        private string stan;
        private string marka_model;
        private string rejestracja;
        private int miejsca;
        private int biletomatID;

        public int BiletomatID
        {
            get { return biletomatID; }
            set
            {
                if (value >= 0)
                {
                    biletomatID = value;
                }
                else
                {
                    biletomatID = 0;
                }
            }
        }

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
        public void infoAutobus()
        {
            Console.WriteLine($"{id} {stan} {marka_model} {rejestracja} {miejsca}");

        }
        public void editAutobus(string stan, string marka_model, int miejsca, string rejestracja,int biletomatID)
        {
            if (!string.IsNullOrEmpty(stan))
            {
                this.stan = stan;
            }

            if (!string.IsNullOrEmpty(marka_model))
            {
                this.marka_model = marka_model;
            }

            if (miejsca >= 0)
            {
                this.miejsca = miejsca;
            }

            if (!string.IsNullOrEmpty(rejestracja))
            {
                this.rejestracja= rejestracja;
            }

            if (biletomatID >= 0)
            {
                this.biletomatID = biletomatID;
            }
        }



            ~Autobus()
        {
            Console.Write("destruktor");

        }
    }
}
