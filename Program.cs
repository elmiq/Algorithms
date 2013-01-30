using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz rodzaj sortowania");
            Console.WriteLine("1.Insertion");

            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Podaj wielkość tablicy");
                string input2 = Console.ReadLine();
                int size = Convert.ToInt32(input2);

                Insertion insertion = new Insertion(size);

                insertion.f_FillTable();



                Console.WriteLine("Przed sortowaniem:");
                insertion.f_WriteItDown();


                Console.WriteLine("Nacisnij Enter aby posortowac");
                Console.ReadKey();

                insertion.f_Sort();


                Console.WriteLine("Po sortowaniu:");
                insertion.f_WriteItDown();


                Console.ReadKey();

            }
        }


    }
}
