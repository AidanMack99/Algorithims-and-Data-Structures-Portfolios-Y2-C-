using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_BinaryTree
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {  //root declared as protected in Parent Class – Binary Tree
        public BSTree()
        {
            root = null;
        }

        public BSTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> root)
        {
            if (root == null)
                root = new Node<T>(item);

            else if (item.CompareTo(root.Data) < 0)
                insertItem(item, ref root.Left);

            else if (item.CompareTo(root.Data) > 0)
                insertItem(item, ref root.Right);
        }


        public int Height(ref Node<T> tree)
        //Return the max level of the tree
        {
            if (tree == null)

                return 0;
            return (1 + Math.Max(Height(ref tree.Left), Height(ref tree.Right)));
        }

        public int Count(ref Node<T> tree)
        //Return the number of nodes in the tree
        {
            int counter = 0;

            if (tree == null)
            {
                return 0;
            }
            else if (tree.Left != null)
            {
                counter += Count(ref tree.Left);
                counter++;
            }

            if (tree.Right != null)
            {
                counter += Count(ref tree.Right);
                counter++;
            }
            return counter;
        }

        public Boolean Contains(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                return false;
            }

            if (tree.Data.Equals(item))
            {
                return true;
            }


            if (item.CompareTo(tree.Data) < 0)
            {
                return Contains(item, ref tree.Left);
            }
            if (item.CompareTo(tree.Data) > 0)
            {
                return Contains(item, ref tree.Right);
            }
            return false;
            
        }

        public void RemoveItem(T item) //covered in lecture 16
        {
        }

    }
}
       
       



