using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = new Node<int>(6);
            root.Left = new Node<int>(2);
            root.Left.Right = new Node<int>(5);
            BinTree<int> tree = new BinTree<int>(root);

            string buffer = "";
            tree.InOrder(ref buffer);
            System.Console.WriteLine(buffer);
            Console.ReadKey();
        }
    }
}
