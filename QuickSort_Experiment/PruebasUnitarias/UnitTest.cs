
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSortAlgoritm;
using System.Linq;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        int[] arreglo;
        QuickSort qs ;

        public int[] Arreglo(int n)
        {
            Random r = new Random();
            arreglo = new int[n];
            qs = new QuickSort();
            for (int i=0; i<n; i++)
            {
                arreglo[i] = r.Next(0, 1000);
            }
            return arreglo;
        }

        [TestMethod]
        public void TestQuickSort()
        {
            Arreglo(100);
            qs.QuickSortMethod(arreglo, 0, arreglo.Length - 1);
            for(int i=0; i<arreglo.Length-1; i++)
            {
                
                Assert.IsFalse(arreglo[i] <= arreglo[i + 1]);
            }
        }
    }
}
