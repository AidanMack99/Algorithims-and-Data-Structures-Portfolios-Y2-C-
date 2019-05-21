using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LinkedListGen
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkGen<int> testlist = new LinkGen<int>(5);
            LinkedListGen<int> list = new LinkedListGen<int>();
            LinkedListGen<int> list2 = new LinkedListGen<int>();



            list.AddItem(10);
            list.AddItem(20);
            list.AddItem(30);
            list.AddItem(40);
            list.AddItem(50);
            list.AddItem(60);
            list.AppendItem(4);

            list2.AddItem(5);
            list2.AddItem(15);
            list2.AddItem(25);
            list2.AddItem(35);
            list2.AddItem(45);

           

            //list2.Copy(list);

            
            list2.DisplayItems();


            Console.WriteLine("Number of Items " + list.NumberOfItems());
            Console.WriteLine(list.DisplayItems());
            Console.WriteLine("Is 10 Present? : " + list.IsPresentItem(10));
            Console.WriteLine(list2.DisplayItems());

            list2.Concat(list);
            Console.WriteLine(list2.DisplayItems());

            list.InsertInOrder(15);
            Console.WriteLine(list.DisplayItems());

            Console.ReadKey();




        }
    }
}
