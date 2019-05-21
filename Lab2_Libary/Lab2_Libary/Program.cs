using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Libary
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[5];  //declare an array of Book

            books[0] = new Book("Moby Dick");
            books[0].Author = new Person("Herman Melville");
            books[1] = new Horror("The Creeping");
            books[2] = new Horror("Insomnia");
            books[3] = new SciFi("The War of the Worlds");
            books[4] = new Fantasy("The Lord of the rings");
            books[0].Author.Age = 32;
            books[1].Author.Age = 56;
            books[2].Author.Age = 56;
            books[3].Author.Age = 86;
            books[4].Author.Age = 63;






            for (int i = 0; i < 5; i++)
                Console.WriteLine(books[i].GetSummary());

            Console.ReadKey();

        }

    }
}
