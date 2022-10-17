using System;
using System.Diagnostics;
using System.IO;

namespace QuickSort
{
    class Program
    {
        static void sortuj(int[] sortowanie, int l, int p)
        {
            int i = l;
            int j = p-1;
            int pivot = sortowanie[(l + p-1) / 2];
            while (i < j)
            {
                while (sortowanie[i] < pivot)
                {
                    i++;
                }

                while (sortowanie[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int zmienna = sortowanie[i];
                    sortowanie[i++] = sortowanie[j];
                    sortowanie[j--] = zmienna;
                }
            }
            if (l < j) sortuj(sortowanie, l, j);
            if (i < p-1) sortuj(sortowanie, i, p-1);
        }

        static void Main(string[] args)
        {
            string czytnik1;
            string czytnik2;
            string czytnik3;
            string czytnik4;
            string czytnik5;
            int indeks;
            indeks = 0;
            int[] arr1 = new int[200001];
            int[] arr2 = new int[200001];
            int[] arr3 = new int[200001];
            int[] arr4 = new int[200001];
            int[] arr5 = new int[200001];
            Stopwatch timera = new Stopwatch();
            Stopwatch timerb = new Stopwatch();
            Stopwatch timerc = new Stopwatch();
            Stopwatch timerd = new Stopwatch();
            Stopwatch timere = new Stopwatch();

            StreamReader dane1 = new System.IO.StreamReader(@"E:\Studia\Sortowanie bąbelkowe\danelosowea.txt");
            while ((czytnik1 = dane1.ReadLine()) != null)
            {
                arr1[indeks] = int.Parse(czytnik1);
                indeks++;
            }

            timera.Start();
            sortuj(arr1, 0, arr1.Length);
            timera.Stop();

            Console.WriteLine("Czas wykonania sortowania: {0} ms", timera.ElapsedMilliseconds);



            indeks = 0;
            StreamReader dane2 = new System.IO.StreamReader(@"E:\Studia\Sortowanie bąbelkowe\danelosoweb.txt");
            while ((czytnik2 = dane2.ReadLine()) != null)
            {
                arr2[indeks] = int.Parse(czytnik2);
                indeks++;
            }

            timerb.Start();
            sortuj(arr2, 0, arr2.Length);
            timerb.Stop();

            Console.WriteLine("Czas wykonania sortowania: {0} ms", timerb.ElapsedMilliseconds);




            indeks = 0;
            StreamReader dane3 = new System.IO.StreamReader(@"E:\Studia\Sortowanie bąbelkowe\danelosowec.txt");
            while ((czytnik3 = dane3.ReadLine()) != null)
            {
                arr3[indeks] = int.Parse(czytnik3);
                indeks++;
            }

            timerc.Start();
            sortuj(arr3, 0, arr3.Length);
            timerc.Stop();

            Console.WriteLine("Czas wykonania sortowania: {0} ms", timerc.ElapsedMilliseconds);




            indeks = 0;
            StreamReader dane4 = new System.IO.StreamReader(@"E:\Studia\Sortowanie bąbelkowe\danelosowed.txt");
            while ((czytnik4 = dane4.ReadLine()) != null)
            {
                arr4[indeks] = int.Parse(czytnik4);
                indeks++;
            }

            timerd.Start();
            sortuj(arr4, 0, arr4.Length);
            timerd.Stop();

            Console.WriteLine("Czas wykonania sortowania: {0} ms", timerd.ElapsedMilliseconds);

            indeks = 0;
            StreamReader dane5 = new System.IO.StreamReader(@"E:\Studia\Sortowanie bąbelkowe\danelosowee.txt");
            while ((czytnik5 = dane5.ReadLine()) != null)
            {
                arr5[indeks] = int.Parse(czytnik5);
                indeks++;
            }

            timere.Start();
            sortuj(arr5, 0, arr5.Length);
            timere.Stop();

            Console.WriteLine("Czas wykonania sortowania: {0} ms", timere.ElapsedMilliseconds);


            Console.ReadKey();
        }
    }
}
