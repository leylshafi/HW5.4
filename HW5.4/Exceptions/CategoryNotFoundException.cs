using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._4.Exceptions
{
    internal class CategoryNotFoundException:Exception
    {
        public CategoryNotFoundException(string message = "Category not found"):base(message)
        {

        }
    }
}
