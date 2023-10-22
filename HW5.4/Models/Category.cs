using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._4.Models
{
    internal class Category : Base
    {
        private static int _count = 0;
        public Category(string name) : base(name)
        {
            Id = ++_count;
        }

        public override string ToString()
        {
            return $@"{Id} | {Name}";
        }
    }
}
