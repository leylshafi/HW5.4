using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._4.Exceptions
{
    internal class WrongInputException:Exception
    {
        public WrongInputException(string message = "Wrong input"):base(message)
        {

        }
    }
}
