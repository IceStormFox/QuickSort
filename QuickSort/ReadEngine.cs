using System;
using System.Diagnostics;
using System.IO;

namespace QuickSort
{
    internal class ReadEngine
    {
        public static void Reader(string path)
        {
            string czytnik;
            int indeks = 0;
            int[] array = new int[200000];
            Stopwatch timer = new Stopwatch();
            StreamReader dane;

            dane = new StreamReader(path);
            while ((czytnik = dane.ReadLine()) != null)
            {
                array[indeks] = int.Parse(czytnik);
                indeks++;
            }

            timer.Start();
            SortEngine.Sort(array, 0, array.Length - 1);
            timer.Stop();


            Console.WriteLine("Czas wykonania sortowania: {0} ms", timer.ElapsedMilliseconds);
        }
    }
}
