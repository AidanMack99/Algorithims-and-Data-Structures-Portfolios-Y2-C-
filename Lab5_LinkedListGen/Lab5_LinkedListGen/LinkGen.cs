using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LinkedListGen
{
    public class LinkGen<T>
    {
        private T data;
        private LinkGen<T> next;

        public LinkGen (T item) //constructor with an item
        {
            data = item;
            next = null;
        }

        public LinkGen (T item, LinkGen<T> list) //constructor with item and li
        {
            data = item;
            next = list;
        }

        public LinkGen<T> Next //property for next
        {
            set { this.next = value; }
            get { return this.next; }
        }

        public T Data //property for data
        {
            set { this.data = value; }
            get { return this.data; }
        }
    }
}
