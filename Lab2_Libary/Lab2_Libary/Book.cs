using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Libary
{
    class Book : IComparable
    {
        private string title;
        private Person author;



        //constructor 
        public Book(string title)
        {
            this.Title = title;
            author = new Person("");

        }


        public string Title
        {
            get { return title; }
            set { title = value; }

        }


        public Person Author
        {
            get { return author; }
            set { author = value; }
        }

        public int CompareTo(Object obj) //implementation of CompareTO
        {
            Book other = (Book)obj;
            return Title.CompareTo(other.Title);//uses Name for comparison
        }

        public string GetSummary()
        {
            string Summary = Title + "," + Author.Name + "," + Author.Age;
            return Summary;

        }
    }



}


