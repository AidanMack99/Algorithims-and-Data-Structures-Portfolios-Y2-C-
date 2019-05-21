
using System;
using System.Collections.Generic;
using System.Text;

namespace BookSortingEx
{
    class Program
    {

        static void swap<T>(ref T x, ref T y)
        {

           //swapcount++;
            T temp = x;
            x = y;
            y = temp;
        }



        
        // Complete the code of the Selection Sort to sort an array of Book
        // To complete this code you need first to complete the CompareTo method in the class Book
        
        static void SelectionSort(Book[] library)
        {
            for (int i = 0; i < library.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < library.Length; j++)
                {
                    if (library[j].CompareTo(library[smallest]) == -1)
                        smallest = j;
                }
                swap(ref library[i], ref library[smallest]);
            }

        }

        static void QuickSortDD2<T>(T[] items, int left, int right) where T:IComparable
        {
            int i, j;
            i = left; j = right;
            IComparable pivot = items[left];

            while (i <= j)
            {
                //for (; (items[i] < pivot) && (i < right); i++) ;
                //for (; (pivot < items[j]) && (j > left); j--) ;
                for (; (items[i].CompareTo(pivot) < 0) && (i.CompareTo(right) < 0); i++);
                for (; (pivot.CompareTo(items[j]) < 0) && (j.CompareTo(left) > 0); j--) ;

                if (i <= j)
                    swap(ref items[i++], ref items[j--]);
            }

            if (left < j) QuickSortDD2<T>(items, left, j);
            if (i < right) QuickSortDD2<T>(items, i, right);
        }






        static void Main(string[] args)
        {


            string[] array1 = { "Fred", "Zoe", "Angela", "Umbrella", "Ben" };
            string[] titles = {"Writing Solid Code",
                "Objects First","Programming Gems",
                "Head First Java","The C Programming Language",
                "Mythical Man Month","The Art of Programming",
                "Coding Complete","Design Patterns", 
                "ZZ"};
            string[] authors ={ "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            string[] isbns = { "948343", "849328493", "38948932", "394834342", "983492389", "84928334", "4839455", "21331322", "348923948", "43893284", "9483294", "9823943" };


            Book[] library = new Book[10];


            int[] ints = { 1, 5, 8, 2, 5, 6 };
            string[] strings = { "Danny", "Abby", "Lacey", "Rory", "Reece", "Carla" };
            

            for (int i = 0; i < library.Length; i++)
            {
                library[i] = new Book(isbns[i], titles[i], authors[i]);
                
            }

            foreach(int x in ints)
            {
                QuickSortDD2(ints, 0, ints.Length - 1);
                Console.WriteLine(" {0} ", x);
            }

            foreach (String x in titles)
            {
                QuickSortDD2(titles, 0, titles.Length - 1);
                Console.WriteLine(x);
            }


             foreach (var item in library)
            {
                QuickSortDD2(library, 0, library.Length - 1);

            }

           // Call selection sort to sort the books in the library

           // SelectionSort(library);



           /* IComparable[] array1 = { 3,5,7,8,1,2 };



           foreach (int s in array1)
           {
            Console.WriteLine(" {0} ", s);
           }

           Console.ReadKey();
           Console.WriteLine("Sorted version");
           foreach (int x in array1)
           {
            QuickSort(array1, 0, array1.Length - 1);
            Console.WriteLine(" {0} ", x);
           }*/


            // Display all the books in the library to check they are correctly sorted (you can use foreach)

            /* foreach (var item in library)
  {
      Console.WriteLine(item.ToString());
  }
  */
            Console.ReadKey();


}

}
}
