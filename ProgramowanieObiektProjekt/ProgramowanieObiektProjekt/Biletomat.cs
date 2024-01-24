using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektProjekt
{
    public class Biletomat
    {
       public Biletomat (int idk, string mo, string s)
        {
            id = idk;
            model = mo;
            stan = s;

        }

        private int id;
        private string model;
        private string stan;

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
        public string Model
        {
            get { return model; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    model = value;
                }
                else
                {
                    model = "brak marki i modelu";

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
        public void infoBiletomat()
        {
            Console.WriteLine($"{id} {stan} {model}");

        }
        public void editBiletomat(string stan, string model)
        {
            if (!string.IsNullOrEmpty(stan))
            {
                this.stan = stan;
            }

            if (!string.IsNullOrEmpty(model))
            {
                this.model = model;
            }
        }

    }
}
