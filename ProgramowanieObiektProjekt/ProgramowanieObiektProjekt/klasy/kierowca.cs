using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektProjekt.klasy
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
                    throw new ArithmeticException("ID nie może być ujemne");
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
                    throw new ArgumentException("pole imie nie może być puste");

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
                    throw new ArgumentException("pole nzawisko nie może być puste");

                }
            }

        }

        public void infoKierowca()
        {
            Console.WriteLine($"kierowca ID:{id}, Imie:{imie},Nazwisko{nazwisko}");

        }
        public void editKierowca(string stan, string model)
        {
            if (!string.IsNullOrEmpty(stan))
            {
                imie = stan;
            }

            if (!string.IsNullOrEmpty(model))
            {
                nazwisko = model;
            }

        }
    }
}
