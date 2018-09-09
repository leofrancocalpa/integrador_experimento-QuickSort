using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_Experiment
{
    class Arreglo
    {

        private int[] arreglo { get; set; }
        private int[] arregloA { get; set; }
        private int[] arregloD { get; set; }
        private Random random;
        private QuickSort qs;

        public Arreglo(int n)
        {
            qs = new QuickSort();
            random = new Random();
            ArregloDesorganizado(n);
            ArregloAscendente();
            ArregloDescendente();
        }

        public void ArregloDesorganizado(int valor)
        {            
            for (int i = 0; i <= valor; i++)
            {
                arreglo[i] = random.Next(0, 1000000000);
                arregloA[i] = random.Next(0, 1000000000);
                arregloD[i] = random.Next(0, 1000000000);
            }
        }

        public void ArregloAscendente()
        {
            qs.RandomizedPartition(arregloA, 0, arregloA.Length - 1);
        }

        public void ArregloDescendente()
        {
            qs.RandomizedPartitionD(arregloD, 0, arregloD.Length - 1);
        }
    }
}
