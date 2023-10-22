using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._4.Exceptions
{
    internal class LibraryNotFoundException:Exception
    {
        public LibraryNotFoundException(string message = "Library not found"):base(message)
        {

        }
    }
}
