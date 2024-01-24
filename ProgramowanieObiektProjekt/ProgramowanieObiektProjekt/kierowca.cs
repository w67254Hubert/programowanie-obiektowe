using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektProjekt
{
    internal class kierowca
    {
        public kierowca(int idk, string imiek, string nazwiskok)
        {
            id = idk;
            imie = imiek;
            nazwisko = nazwiskok;

        }
        private int id;
        private string imie;
        private string nazwisko;

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

        public string Imie
        {
            get { return imie; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    imie = value;
                }
                else
                {
                    imie = "brak imienia";

                }
            }
        }


        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nazwisko = value;
                }
                else
                {
                    nazwisko = "brak nazwiska";

                }
            }

        }

        public void infoKierowca()
        {
            Console.WriteLine($"{id} {imie} {nazwisko}");

        }
        public void editKierowca(string stan, string model)
        {
            if (!string.IsNullOrEmpty(stan))
            {
                this.imie = stan;
            }

            if (!string.IsNullOrEmpty(model))
            {
                this.nazwisko = model;
            }

        }
    }
}
