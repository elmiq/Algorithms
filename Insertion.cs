using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort
{
    class Insertion
    {
        private int[] A;

        public Insertion(int size)
        {
            A = new int[size];
        }

        public void f_FillTable()
        {
            Random rand = new Random();

            for (int i = 0; i < A.Length; ++i)
            {
                A[i] = rand.Next(0, 1000);
            }
        }

        public void f_WriteItDown()
        {
            for (int i = 0; i < A.Length; ++i)
            {
                if (i != 0)
                    Console.Write(",");
                Console.Write(A[i]);
            }
            Console.WriteLine();
        }

        public void f_Sort()
        {
            int value = 0;
            int j = 0;

            for (int i = 1; i < A.Length; ++i)   //Pętla od drugiego do ostatniego elementu tablicy
            {
                value = A[i];                    //Przypisuje wartość elementu na którym stoje do zmiennej
                j = i - 1;                       //Ustawiam indeks do poruszania się w przeciwnym kierunku niż główna pętla na pozycję po lewej od aktualnego indeksu głównej pętli
                while (j >= 0 && A[j] > value)   /*Dopóki nie dojdę do początku tablicy porównuje wartości. Jeżeli wartość z indeksu pętli poruszającej się w lewo jest większa niż ta
                                                 którą przypisuje do zmiennej value w każdej iteracji pętli for, to przesuwam element o indeksie j w prawo. (początkowa wartość jest zapamiętana
                                                 więc nic nie zginie !) Po takim przesunięciu pętla zmniejszam indeks j przez co przesuwam się w lewo. Wychodzę z pętli while w momencie
                                                 gdy dotrę do początku tablicy, lub w przypadku gdy element o indeksie j jest mniejszy niż value, czyli wtedy gdy znalazłem miejsce dla elementu o indeksie i*/ 
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;                 // Na koniec value jest wstawiana w odpowiednie miejsce i następuje kolejna iteracja pętli for

            }
        }

    }
}
