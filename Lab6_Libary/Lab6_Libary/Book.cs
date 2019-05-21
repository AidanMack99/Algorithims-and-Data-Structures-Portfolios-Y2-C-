﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Libary
{
    class Book
    {
        private String isbn;
        private String title;

        private Boolean onloan;

        public Book(string isbn, string title)
        {
            this.isbn = isbn;
            this.title = title;
            
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Boolean Onloan
        {
            get { return Onloan; }
            set { Onloan = false; }
        }
    }
}
