using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList testList = new LinkedList();

            testList.AddItem(10);
            testList.AddItem(20);
            testList.AddItem(30);
            testList.AddItem(40);
            testList.AddItem(50);
            testList.AddItem(60);
            //testList.RemoveItem(10);

            

            Console.WriteLine("Number of Items " + testList.NumberOfItems());
            Console.WriteLine("Display Items : " + testList.DisplayItems());
            Console.WriteLine("Is 10 Present? : " + testList.IsPresentItem(10));
            Console.ReadKey();
        }
    }
}
