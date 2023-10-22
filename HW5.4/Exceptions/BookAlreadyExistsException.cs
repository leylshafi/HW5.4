using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._4.Exceptions
{
    internal class BookAlreadyExistsException : Exception
    {
        public BookAlreadyExistsException(string message = "Book already exists") : base(message) { }
    }
}
