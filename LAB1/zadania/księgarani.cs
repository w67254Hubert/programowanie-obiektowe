using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class księgarania
    {
        List<Book> books = new List<Book>();

        public void Add(Book item)
        {
            item.Id = books.Count + 1;
            books.Add(item);
        }

        public List<Book> GetAll()
        {
            return books;
        }

        public void Update(Book book)
        {
            var item = books.Find(x => x.Id == book.Id);

            item.Author = book.Author;
        }
}
