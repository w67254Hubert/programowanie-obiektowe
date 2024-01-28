using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
//ta według tej klasy mamy obiekt autobus metody opisują autobus
namespace ProgramowanieObiektProjekt.klasy
{
    public class Autobus
    {
        public Autobus(int kid, string kstan, string kmarka_model, int kmiejsca, string krejestracja, int kbiletomatID, int kkierowcaid)
        {
            ID = kid;
            Stan = kstan;
            Marka_model = kmarka_model;
            Rejestracja = krejestracja;
            Miejsca = kmiejsca;
            biletomatID = kbiletomatID;
            kierowcaID = kkierowcaid;
        }


        private int id;
        private string stan;
        private string marka_model;
        private string rejestracja;
        private int miejsca;
        private int biletomatID;
        private int kierowcaID;
        public int KierowcaID
        {
            get { return kierowcaID; }
            set
            {
                if (value >= 0)
                {
                    kierowcaID = value;
                }
                else
                {
                    throw new ArithmeticException("kierowca ID nie może być ujemne");
                }
            }

        }

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
                    throw new ArgumentException("biletomat ID nie może być ujemne");
                }
            }
        }

        public int Miejsca
        {
            get { return miejsca; }
            set
            {
                if (value > 0)
                {
                    miejsca = value;
                }
                else
                {
                    throw new ArithmeticException("pole Miejsca nie może być ujemne lub zero");
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
                    rejestracja = value;

                }
                else
                {
                    rejestracja = "Brak Rejestracji";

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
                    throw new ArgumentException("pole model nie może być puste");

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
                    throw new ArgumentException("ID nie może być ujemne");
                }
            }
        }

        public void infoAutobus()
        {
            Console.WriteLine($"autobus ID:{id}, Stan:{stan}, Markę:{marka_model}, Rejsstracja:{rejestracja}, Ilość miejsc:{miejsca}");

        }
        public void editAutobus(string stan, string marka_model, int miejsca, string rejestracja, int biletomatID, int kierowcaID)
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
                this.rejestracja = rejestracja;
            }

            if (biletomatID >= 0)
            {
                this.biletomatID = biletomatID;
            }
            if (kierowcaID >= 0)
            {
                this.kierowcaID = kierowcaID;
            }
        } 

        ~Autobus()
        {
            Console.Write("destruktor uwuwa obiekty");

        }
    }
}
