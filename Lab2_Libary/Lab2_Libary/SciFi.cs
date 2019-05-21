using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Libary
{
    class SciFi : Book
    {
        public SciFi(string title) : base(title)
        {
            base.Author = new Person("H.G.Wells");


        }
    }
}
