using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._4.Exceptions
{
    internal class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message = "Book not found") : base(message) { }

    }
}
