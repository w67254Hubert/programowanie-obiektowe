using System;

namespace zadania
{
    class program
    {
        static void Main(string[] args)
        {
            var book = new ksienga( "kiedyś to było");
            Console.WriteLine(book.autor);
            book.info();
        }

    }


}