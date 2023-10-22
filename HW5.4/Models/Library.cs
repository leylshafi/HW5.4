using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._4.Models
{
    internal class Library : Base
    {
        List<Book> _books;
        private static int _count = 0;
        public Library(string name) : base(name)
        {
            Id = ++_count;
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void ListAllBooks()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine(book);
            }

        }
        public override string ToString()
        {
            return $"{Id} | {Name}";
        }

    }
}
