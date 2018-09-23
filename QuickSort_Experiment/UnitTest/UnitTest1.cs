using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort_Experiment;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        int[] array;
        int[] arrayA;
        int[] arrayD;
        Arreglo a;
        QuickSort qs=new QuickSort();

        public void setEscene0()
        {
            a = new Arreglo();
            array = a.ArregloDesorganizado(100);
            arrayA = a.ArregloAscendente();
            arrayD = a.ArregloDescendente();
        }

        public void setEscene1()
        {
            a = new Arreglo();
            array = a.ArregloDesorganizado(100000);
            arrayA = a.ArregloAscendente();
            arrayD = a.ArregloDescendente();
        }

        public void setEscene2()
        {
            Random r = new Random();
            a = new Arreglo();
            array = a.ArregloDesorganizado(r.Next(10,100000));
            arrayA = a.ArregloAscendente();
            arrayD = a.ArregloDescendente();
        }

        //Test QuickSort entradas pequeñas
        [TestMethod]
        public void TestEPQS()
        {
            setEscene0();
            qs.QuickSortMethod(array, 0, array.Length - 1);
            qs.QuickSortMethod(arrayA, 0, array.Length - 1);
            qs.QuickSortMethod(arrayD, 0, array.Length - 1);
            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
                Assert.IsTrue(arrayA[i] <= arrayA[i + 1]);
                Assert.IsTrue(arrayD[i] <= arrayD[i + 1]);
            }
        }

        //Test Random QuickSort entradas pequeñas
        [TestMethod]
        public void TestEPRandomQS()
        {
            setEscene0();
            qs.RandomizedQS(array, 0, array.Length - 1);
            qs.RandomizedQS(arrayA, 0, array.Length - 1);
            qs.RandomizedQS(arrayD, 0, array.Length - 1);
            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
                Assert.IsTrue(arrayA[i] <= arrayA[i + 1]);
                Assert.IsTrue(arrayD[i] <= arrayD[i + 1]);
            }
        }

        //Test QuickSort entradas Grandes
        [TestMethod]
        public void TestEGQS()
        {
            setEscene1();
            qs.QuickSortMethod(array, 0, array.Length - 1);
            qs.QuickSortMethod(arrayA, 0, array.Length - 1);
            qs.QuickSortMethod(arrayD, 0, array.Length - 1);
            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
                Assert.IsTrue(arrayA[i] <= arrayA[i + 1]);
                Assert.IsTrue(arrayD[i] <= arrayD[i + 1]);
            }
        }

        //Test Random QuickSort entradas Grandes
        [TestMethod]
        public void TestEGRandomQS()
        {
            setEscene1();
            qs.RandomizedQS(array, 0, array.Length - 1);
            qs.RandomizedQS(arrayA, 0, array.Length - 1);
            qs.RandomizedQS(arrayD, 0, array.Length - 1);
            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
                Assert.IsTrue(arrayA[i] <= arrayA[i + 1]);
                Assert.IsTrue(arrayD[i] <= arrayD[i + 1]);
            }
        }

        //Test QuickSort entradas Aleatorias
        [TestMethod]
        public void TestEAQS()
        {
            setEscene2();
            qs.QuickSortMethod(array, 0, array.Length - 1);
            qs.QuickSortMethod(arrayA, 0, array.Length - 1);
            qs.QuickSortMethod(arrayD, 0, array.Length - 1);
            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
                Assert.IsTrue(arrayA[i] <= arrayA[i + 1]);
                Assert.IsTrue(arrayD[i] <= arrayD[i + 1]);
            }
        }

        //Test Random QuickSort entradas aleatorias
        [TestMethod]
        public void TestEARandomQS()
        {
            setEscene2();
            qs.RandomizedQS(array, 0, array.Length - 1);
            qs.RandomizedQS(arrayA, 0, array.Length - 1);
            qs.RandomizedQS(arrayD, 0, array.Length - 1);
            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
                Assert.IsTrue(arrayA[i] <= arrayA[i + 1]);
                Assert.IsTrue(arrayD[i] <= arrayD[i + 1]);
            }
        }

    }
}
