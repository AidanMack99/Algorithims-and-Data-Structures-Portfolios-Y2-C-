using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        
        static int multiply(int x, int y)
        {
            if(y==1)
            {
                return x;
            }
            else
            {
                return ( x + multiply(x, dec(y)));
            }
            
        }

        static int power(int x, int y)
        {
            if (y==0)
            {
                return 1;
            }
            else
            {
                return (x * power(x, dec(y)));
            }
        }

        static int inc (int x)
        {
            return x - 1;
        }

        static int dec(int x)
        {
            return x - 1;
        }

        static void Main(string[] args)
        {
           Console.WriteLine(multiply(3,8));
            Console.WriteLine(power(2, 6));
            Console.WriteLine("{0}", dec(dec(10)));
           Console.ReadKey();
        }
    }
}
