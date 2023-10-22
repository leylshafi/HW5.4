using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._4.Models
{
    internal class Book : Base
    {
        private static int _count = 0;
        public string Author { get; set; }
        public int CategoryId { get; set; }

        public Book(string name, string author, int catId) : base(name)
        {
            Id = ++_count;
            Author = author;
            CategoryId = catId;
        }

        public override string ToString()
        {
            return $"{Id} | {Name}";
        }


    }
}
