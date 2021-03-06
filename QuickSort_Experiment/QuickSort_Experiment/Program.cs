﻿using System;
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
            QuickSort qs = new QuickSort();
            Arreglo a = new Arreglo();

            for(int pot=1; pot < 6; pot++)
            {
                if (pot == 1)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("   Experimento entrada 10^1");
                    Console.WriteLine("********************************");
                    Console.WriteLine("\n");
                    List<Double> TRQSA = new List<Double>();
                    List<Double> TRQSD = new List<Double>();
                    List<Double> TRQS = new List<Double>();
                    List<Double> TQSA = new List<Double>();
                    List<Double> TQSD = new List<Double>();
                    List<Double> TQS = new List<Double>();
                    int n =(int) Math.Pow(10,pot);
                    for (int i = 0; i < 1000; i++)
                    {
                        int[] array = a.ArregloDesorganizado(n);
                        int[] arrayA = a.ArregloAscendente();
                        int[] arrayD = a.ArregloDescendente();

                        //No Descendente
                        //QS case 1
                        int[] arrayA0 = (int[])arrayA.Clone();
                        TimeSpan stop0;
                        TimeSpan start0 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA0, 0, n - 1);

                        stop0 = new TimeSpan(DateTime.Now.Ticks);
                        TQSA.Add(stop0.Subtract(start0).TotalMilliseconds);

                        //RanQS case 2
                        int[] arrayA1 = (int[])arrayA.Clone();
                        TimeSpan stop1;
                        TimeSpan start1 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA1, 0, n - 1);

                        stop1 = new TimeSpan(DateTime.Now.Ticks);
                        TRQSA.Add(stop1.Subtract(start1).TotalMilliseconds);

                        //No Ascendente
                        //QS case3
                        int[] arrayA2 = (int[])arrayD.Clone();
                        TimeSpan stop2;
                        TimeSpan start2 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA2, 0, n - 1);

                        stop2 = new TimeSpan(DateTime.Now.Ticks);
                        TQSD.Add(stop2.Subtract(start2).TotalMilliseconds);

                        //RanQS case 4
                        int[] arrayA3 = (int[])arrayD.Clone();
                        TimeSpan stop3;
                        TimeSpan start3 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA3, 0, n - 1);

                        stop3 = new TimeSpan(DateTime.Now.Ticks);
                        TRQSD.Add(stop3.Subtract(start3).TotalMilliseconds);

                        //Aleatorio
                        //QS case 5
                        int[] arrayA4 = (int[])array.Clone();
                        TimeSpan stop4;
                        TimeSpan start4 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA4, 0, n - 1);

                        stop4 = new TimeSpan(DateTime.Now.Ticks);
                        TQS.Add(stop4.Subtract(start4).TotalMilliseconds);

                        //RanQS case 6
                        int[] arrayA5 = (int[])arrayD.Clone();
                        TimeSpan stop5;
                        TimeSpan start5 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA5, 0, n - 1);

                        stop5 = new TimeSpan(DateTime.Now.Ticks);
                        TRQS.Add(stop5.Subtract(start5).TotalMilliseconds);
                    }
                    Console.WriteLine("Tiempo QS entrada Ascendente: {0}", TQSA.Average());
                    Console.WriteLine("Tiempo RQS entrada Ascendente: {0}", TRQSA.Average());
                    Console.WriteLine("Tiempo QS entrada Descendente: {0}", TQSD.Average());
                    Console.WriteLine("Tiempo RQS entrada Descendente: {0}", TRQSD.Average());
                    Console.WriteLine("Tiempo QS entrada Aleatoria: {0}", TQS.Average());
                    Console.WriteLine("Tiempo RQS entrada Aleatoria: {0}", TRQS.Average());
                    Console.WriteLine("\n");
                }
                if (pot == 2)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("   Experimento entrada 10^2");
                    Console.WriteLine("********************************");
                    Console.WriteLine("\n");
                    List<Double> TRQSA = new List<Double>();
                    List<Double> TRQSD = new List<Double>();
                    List<Double> TRQS = new List<Double>();
                    List<Double> TQSA = new List<Double>();
                    List<Double> TQSD = new List<Double>();
                    List<Double> TQS = new List<Double>();
                    int n = (int)Math.Pow(10, pot);
                    for (int i = 0; i < 1000; i++)
                    {
                        int[] array = a.ArregloDesorganizado(n);
                        int[] arrayA = a.ArregloAscendente();
                        int[] arrayD = a.ArregloDescendente();

                        //No Descendente
                        //QS case 1
                        int[] arrayA0 = (int[])arrayA.Clone();
                        TimeSpan stop0;
                        TimeSpan start0 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA0, 0, n - 1);

                        stop0 = new TimeSpan(DateTime.Now.Ticks);
                        TQSA.Add(stop0.Subtract(start0).TotalMilliseconds);

                        //RanQS case 2
                        int[] arrayA1 = (int[])arrayA.Clone();
                        TimeSpan stop1;
                        TimeSpan start1 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA1, 0, n - 1);

                        stop1 = new TimeSpan(DateTime.Now.Ticks);
                        TRQSA.Add(stop1.Subtract(start1).TotalMilliseconds);

                        //No Ascendente
                        //QS case3
                        int[] arrayA2 = (int[])arrayD.Clone();
                        TimeSpan stop2;
                        TimeSpan start2 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA2, 0, n - 1);

                        stop2 = new TimeSpan(DateTime.Now.Ticks);
                        TQSD.Add(stop2.Subtract(start2).TotalMilliseconds);

                        //RanQS case 4
                        int[] arrayA3 = (int[])arrayD.Clone();
                        TimeSpan stop3;
                        TimeSpan start3 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA3, 0, n - 1);

                        stop3 = new TimeSpan(DateTime.Now.Ticks);
                        TRQSD.Add(stop3.Subtract(start3).TotalMilliseconds);

                        //Aleatorio
                        //QS case 5
                        int[] arrayA4 = (int[])array.Clone();
                        TimeSpan stop4;
                        TimeSpan start4 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA4, 0, n - 1);

                        stop4 = new TimeSpan(DateTime.Now.Ticks);
                        TQS.Add(stop4.Subtract(start4).TotalMilliseconds);

                        //RanQS case 6
                        int[] arrayA5 = (int[])arrayD.Clone();
                        TimeSpan stop5;
                        TimeSpan start5 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA5, 0, n - 1);

                        stop5 = new TimeSpan(DateTime.Now.Ticks);
                        TRQS.Add(stop5.Subtract(start5).TotalMilliseconds);
                    }
                    Console.WriteLine("Tiempo QS entrada Ascendente: {0}", TQSA.Average());
                    Console.WriteLine("Tiempo RQS entrada Ascendente: {0}", TRQSA.Average());
                    Console.WriteLine("Tiempo QS entrada Descendente: {0}", TQSD.Average());
                    Console.WriteLine("Tiempo RQS entrada Descendente: {0}", TRQSD.Average());
                    Console.WriteLine("Tiempo QS entrada Aleatoria: {0}", TQS.Average());
                    Console.WriteLine("Tiempo RQS entrada Aleatoria: {0}", TRQS.Average());
                    Console.WriteLine("\n");
                }
                if (pot == 3)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("   Experimento entrada 10^3");
                    Console.WriteLine("********************************");
                    Console.WriteLine("\n");
                    List<Double> TRQSA = new List<Double>();
                    List<Double> TRQSD = new List<Double>();
                    List<Double> TRQS = new List<Double>();
                    List<Double> TQSA = new List<Double>();
                    List<Double> TQSD = new List<Double>();
                    List<Double> TQS = new List<Double>();
                    int n = (int)Math.Pow(10, pot);
                    for (int i = 0; i < 1000; i++)
                    {
                        int[] array = a.ArregloDesorganizado(n);
                        int[] arrayA = a.ArregloAscendente();
                        int[] arrayD = a.ArregloDescendente();

                        //No Descendente
                        //QS case 1
                        int[] arrayA0 = (int[])arrayA.Clone();
                        TimeSpan stop0;
                        TimeSpan start0 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA0, 0, n - 1);

                        stop0 = new TimeSpan(DateTime.Now.Ticks);
                        TQSA.Add(stop0.Subtract(start0).TotalMilliseconds);

                        //RanQS case 2
                        int[] arrayA1 = (int[])arrayA.Clone();
                        TimeSpan stop1;
                        TimeSpan start1 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA1, 0, n - 1);

                        stop1 = new TimeSpan(DateTime.Now.Ticks);
                        TRQSA.Add(stop1.Subtract(start1).TotalMilliseconds);

                        //No Ascendente
                        //QS case3
                        int[] arrayA2 = (int[])arrayD.Clone();
                        TimeSpan stop2;
                        TimeSpan start2 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA2, 0, n - 1);

                        stop2 = new TimeSpan(DateTime.Now.Ticks);
                        TQSD.Add(stop2.Subtract(start2).TotalMilliseconds);

                        //RanQS case 4
                        int[] arrayA3 = (int[])arrayD.Clone();
                        TimeSpan stop3;
                        TimeSpan start3 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA3, 0, n - 1);

                        stop3 = new TimeSpan(DateTime.Now.Ticks);
                        TRQSD.Add(stop3.Subtract(start3).TotalMilliseconds);

                        //Aleatorio
                        //QS case 5
                        int[] arrayA4 = (int[])array.Clone();
                        TimeSpan stop4;
                        TimeSpan start4 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA4, 0, n - 1);

                        stop4 = new TimeSpan(DateTime.Now.Ticks);
                        TQS.Add(stop4.Subtract(start4).TotalMilliseconds);

                        //RanQS case 6
                        int[] arrayA5 = (int[])arrayD.Clone();
                        TimeSpan stop5;
                        TimeSpan start5 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA5, 0, n - 1);

                        stop5 = new TimeSpan(DateTime.Now.Ticks);
                        TRQS.Add(stop5.Subtract(start5).TotalMilliseconds);
                    }
                    Console.WriteLine("Tiempo QS entrada Ascendente: {0}", TQSA.Average());
                    Console.WriteLine("Tiempo RQS entrada Ascendente: {0}", TRQSA.Average());
                    Console.WriteLine("Tiempo QS entrada Descendente: {0}", TQSD.Average());
                    Console.WriteLine("Tiempo RQS entrada Descendente: {0}", TRQSD.Average());
                    Console.WriteLine("Tiempo QS entrada Aleatoria: {0}", TQS.Average());
                    Console.WriteLine("Tiempo RQS entrada Aleatoria: {0}", TRQS.Average());
                    Console.WriteLine("\n");
                }
                if (pot == 4)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("   Experimento entrada 10^4");
                    Console.WriteLine("********************************");
                    Console.WriteLine("\n");
                    List<Double> TRQSA = new List<Double>();
                    List<Double> TRQSD = new List<Double>();
                    List<Double> TRQS = new List<Double>();
                    List<Double> TQSA = new List<Double>();
                    List<Double> TQSD = new List<Double>();
                    List<Double> TQS = new List<Double>();
                    int n = (int)Math.Pow(10, pot);
                    for (int i = 0; i < 1000; i++)
                    {
                        int[] array = a.ArregloDesorganizado(n);
                        int[] arrayA = a.ArregloAscendente();
                        int[] arrayD = a.ArregloDescendente();

                        //No Descendente
                        //QS case 1
                        int[] arrayA0 = (int[])arrayA.Clone();
                        TimeSpan stop0;
                        TimeSpan start0 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA0, 0, n - 1);

                        stop0 = new TimeSpan(DateTime.Now.Ticks);
                        TQSA.Add(stop0.Subtract(start0).TotalMilliseconds);

                        //RanQS case 2
                        int[] arrayA1 = (int[])arrayA.Clone();
                        TimeSpan stop1;
                        TimeSpan start1 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA1, 0, n - 1);

                        stop1 = new TimeSpan(DateTime.Now.Ticks);
                        TRQSA.Add(stop1.Subtract(start1).TotalMilliseconds);

                        //No Ascendente
                        //QS case3
                        int[] arrayA2 = (int[])arrayD.Clone();
                        TimeSpan stop2;
                        TimeSpan start2 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA2, 0, n - 1);

                        stop2 = new TimeSpan(DateTime.Now.Ticks);
                        TQSD.Add(stop2.Subtract(start2).TotalMilliseconds);

                        //RanQS case 4
                        int[] arrayA3 = (int[])arrayD.Clone();
                        TimeSpan stop3;
                        TimeSpan start3 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA3, 0, n - 1);

                        stop3 = new TimeSpan(DateTime.Now.Ticks);
                        TRQSD.Add(stop3.Subtract(start3).TotalMilliseconds);

                        //Aleatorio
                        //QS case 5
                        int[] arrayA4 = (int[])array.Clone();
                        TimeSpan stop4;
                        TimeSpan start4 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA4, 0, n - 1);

                        stop4 = new TimeSpan(DateTime.Now.Ticks);
                        TQS.Add(stop4.Subtract(start4).TotalMilliseconds);

                        //RanQS case 6
                        int[] arrayA5 = (int[])arrayD.Clone();
                        TimeSpan stop5;
                        TimeSpan start5 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA5, 0, n - 1);

                        stop5 = new TimeSpan(DateTime.Now.Ticks);
                        TRQS.Add(stop5.Subtract(start5).TotalMilliseconds);
                    }
                    Console.WriteLine("Tiempo QS entrada Ascendente: {0}", TQSA.Average());
                    Console.WriteLine("Tiempo RQS entrada Ascendente: {0}", TRQSA.Average());
                    Console.WriteLine("Tiempo QS entrada Descendente: {0}", TQSD.Average());
                    Console.WriteLine("Tiempo RQS entrada Descendente: {0}", TRQSD.Average());
                    Console.WriteLine("Tiempo QS entrada Aleatoria: {0}", TQS.Average());
                    Console.WriteLine("Tiempo RQS entrada Aleatoria: {0}", TRQS.Average());
                    Console.WriteLine("\n");
                }
                if (pot == 5)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("   Experimento entrada 10^5");
                    Console.WriteLine("********************************");
                    Console.WriteLine("\n");
                    List<Double> TRQSA = new List<Double>();
                    List<Double> TRQSD = new List<Double>();
                    List<Double> TRQS = new List<Double>();
                    List<Double> TQSA = new List<Double>();
                    List<Double> TQSD = new List<Double>();
                    List<Double> TQS = new List<Double>();
                    int n = (int)Math.Pow(10, pot);
                    for (int i = 0; i < 1000; i++)
                    {
                        int[] array = a.ArregloDesorganizado(n);
                        int[] arrayA = a.ArregloAscendente();
                        int[] arrayD = a.ArregloDescendente();

                        //No Descendente
                        //QS case 1
                        int[] arrayA0 = (int[])arrayA.Clone();
                        TimeSpan stop0;
                        TimeSpan start0 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA0, 0, n - 1);

                        stop0 = new TimeSpan(DateTime.Now.Ticks);
                        TQSA.Add(stop0.Subtract(start0).TotalMilliseconds);

                        //RanQS case 2
                        int[] arrayA1 = (int[])arrayA.Clone();
                        TimeSpan stop1;
                        TimeSpan start1 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA1, 0, n - 1);

                        stop1 = new TimeSpan(DateTime.Now.Ticks);
                        TRQSA.Add(stop1.Subtract(start1).TotalMilliseconds);

                        //No Ascendente
                        //QS case3
                        int[] arrayA2 = (int[])arrayD.Clone();
                        TimeSpan stop2;
                        TimeSpan start2 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA2, 0, n - 1);

                        stop2 = new TimeSpan(DateTime.Now.Ticks);
                        TQSD.Add(stop2.Subtract(start2).TotalMilliseconds);

                        //RanQS case 4
                        int[] arrayA3 = (int[])arrayD.Clone();
                        TimeSpan stop3;
                        TimeSpan start3 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA3, 0, n - 1);

                        stop3 = new TimeSpan(DateTime.Now.Ticks);
                        TRQSD.Add(stop3.Subtract(start3).TotalMilliseconds);

                        //Aleatorio
                        //QS case 5
                        int[] arrayA4 = (int[])array.Clone();
                        TimeSpan stop4;
                        TimeSpan start4 = new TimeSpan(DateTime.Now.Ticks);

                        qs.QuickSortMethod(arrayA4, 0, n - 1);

                        stop4 = new TimeSpan(DateTime.Now.Ticks);
                        TQS.Add(stop4.Subtract(start4).TotalMilliseconds);

                        //RanQS case 6
                        int[] arrayA5 = (int[])arrayD.Clone();
                        TimeSpan stop5;
                        TimeSpan start5 = new TimeSpan(DateTime.Now.Ticks);

                        qs.RandomizedQS(arrayA5, 0, n - 1);

                        stop5 = new TimeSpan(DateTime.Now.Ticks);
                        TRQS.Add(stop5.Subtract(start5).TotalMilliseconds);
                    }
                    Console.WriteLine("Tiempo QS entrada Ascendente: {0}", TQSA.Average());
                    Console.WriteLine("Tiempo RQS entrada Ascendente: {0}", TRQSA.Average());
                    Console.WriteLine("Tiempo QS entrada Descendente: {0}", TQSD.Average());
                    Console.WriteLine("Tiempo RQS entrada Descendente: {0}", TRQSD.Average());
                    Console.WriteLine("Tiempo QS entrada Aleatoria: {0}", TQS.Average());
                    Console.WriteLine("Tiempo RQS entrada Aleatoria: {0}", TRQS.Average());
                    Console.WriteLine("\n");
                }
                
            }
        }
    }
}
