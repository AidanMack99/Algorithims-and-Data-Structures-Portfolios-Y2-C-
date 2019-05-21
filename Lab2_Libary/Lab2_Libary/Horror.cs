using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Libary
{
    class Horror : Book
    {
        public Horror(string title) : base(title)
        {
            base.Author = new Person("Stephen King");
            base.Author = new Person("Alexandra Sirowy");


        }
    }
}
