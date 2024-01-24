using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class ksienga
    {
        public ksienga(string n)
        {
            nazwa = n;
        }
        public long Id { get; set; }
        public string nazwa = "nazwa";
        public string autor="twój stary";
        public int rokWydania = 1122;

        
        public void info()
        {
            Console.WriteLine($"{nazwa}{autor}{rokWydania}");
        }
    }

}