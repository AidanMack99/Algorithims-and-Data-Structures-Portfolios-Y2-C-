using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = new Node<int>(6);
            
           


            BSTree<int> bst = new BSTree<int>(root);
            
            bst.InsertItem(1);
            bst.InsertItem(3);
            bst.InsertItem(21);
            bst.InsertItem(23);
            bst.InsertItem(42);
            bst.InsertItem(113);
            bst.InsertItem(2323);
            bst.InsertItem(4412);
            

            
            Console.WriteLine(bst.Count(ref root));
            Console.WriteLine(bst.Height(ref root));

            if(bst.Contains(21, ref root))
            {
                Console.WriteLine("tree contains 21");
            }


            if(!bst.Contains(22, ref root))
            {
                Console.WriteLine("tree doesn't contain 22");
            }
           // bst.Height(ref buffer);

            
            Console.ReadKey();
        }
    }
}
