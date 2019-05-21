using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LinkedListGen
{
    class LinkedListGen<T> where T:IComparable
    {
        private LinkGen<T> list; // default value (empty list)

        public LinkedListGen()
        {
            list = null;
        }

        public void AddItem(T item) //add item to front of list
        {
            list = new LinkGen<T>(item, list);
        }


        public string DisplayItems() //write items to string and return
        {
            LinkGen<T> temp = list;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                buffer += temp.Data + " ";
                temp = temp.Next;
            }
            
            return buffer;
        }


        public int NumberOfItems() // returns number of items in list
        {
            LinkGen<T> temp = list;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                count++;
                temp = temp.Next;

            }
            return count;
        }



        public bool IsPresentItem(T item)
        {
            LinkGen<T> temp = list;
            while (temp != null)
            {
                if (item.Equals(temp.Data))
                {
                    //Console.WriteLine("true");
                    return true;
                }
                temp = temp.Next;

            }
            return false;
        }




        public void RemoveItem(T item)
        {
            LinkGen<T> current = list;
            LinkGen<T> previous = null;

            while (current != null)
            {
                if (item.Equals(current.Data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        current = current.Next;
                    }

                    else
                    {
                        previous = current;
                        current = current.Next;
                        list = current;
                    }

                }
                else
                {
                    previous = current;
                    current = current.Next;
                }
            }
        }

        public void AppendItem (T item)
        {
            LinkGen<T> temp = list;

            if (temp == null)
            
                list = new LinkGen<T>(item);
                            
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new LinkGen<T>(item);
            }
        }

        public void Concat(LinkedListGen<T> list2)
        {
            LinkGen<T> temp = list2.list;
            while (temp != null)
            {
                AppendItem(temp.Data);
                temp = temp.Next;
            }
        }




        public void Copy(LinkedListGen<T> list2)
        {

            LinkGen<T> temp = list2.list;
            while (temp != null)
            {
                AppendItem(temp.Data);
                temp = temp.Next;
            }
        }




        public void InsertInOrder(T item)
        {
            LinkGen<T> temp = list;

            if (list == null || list.Data.CompareTo(item) < 0)
            {
                list = new LinkGen<T>(item, this.list);
            }
            else
            {
                while (temp != null)
                {

                    if (list.Data.CompareTo(item) == 0 || list.Data.CompareTo(item) > 0)
                    {
                        temp.Next = new LinkGen<T>(item, temp.Next);

                        temp = null;
                    }
                    else
                    {

                        temp = temp.Next;
                    }
                }


            }

        }

    }
}
