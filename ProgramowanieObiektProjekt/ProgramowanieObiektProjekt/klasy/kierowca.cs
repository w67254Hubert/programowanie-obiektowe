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
                    throw new ArithmeticException("ID nie może być ujemne/puste");
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
        public void editKierowca(string imie1, string nazwisko1)
        {
            if (!string.IsNullOrEmpty(imie1))
            {
                imie = imie1;
            }
            else { Console.WriteLine($"obiekt klasy kierowca {ID} WArtość nie zostałą zmieniona {imie1}"); }

            if (!string.IsNullOrEmpty(nazwisko1))
            {
                nazwisko = nazwisko1;
            }
            else { Console.WriteLine($"obiekt klasy kierowca {ID} WArtość nie zostałą zmieniona {imie1}"); }


        }

        ~kierowca()
        {
            Console.Write("destruktor uwuwa obiekty");

        }
    }
}
