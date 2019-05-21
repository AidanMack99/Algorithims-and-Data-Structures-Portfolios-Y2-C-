using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Libary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Book book1 = new Book("1234BN", "Moby Dick");
            Book book2 = new Book("5647BN", "Ullysses");
            books.Add(book1);
            books.Add(book2);
            foreach (Book b in books)
                Console.WriteLine(b.ISBN+ " " + b.Title);
            Console.ReadKey();
        }
    }
}
