using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Libary
{
    class Person : IComparable
    {
        private int age;
        private string name;


        //constructor
        public Person(string name)
        {
            this.name = name;
            age = 18; //default age 
        }

        //property for name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int CompareTo(Object obj) //implementation of CompareTO
        {
            Person other = (Person)obj;
            return Name.CompareTo(other.Name);//uses Name for comparison
        }
    }
}


