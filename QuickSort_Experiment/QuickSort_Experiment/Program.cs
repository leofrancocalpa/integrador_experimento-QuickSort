using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_Experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];
            Random r = new Random();
            QuickSort qs = new QuickSort();
            for (int i = 0; i < 10; i++)
            {
                arreglo[i] = r.Next(0, 100000000);
            }
            qs.RandomizedQS(arreglo, 0, arreglo.Length - 1);
            Console.WriteLine("Done!");
            Console.ReadLine();
            arreglo.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
