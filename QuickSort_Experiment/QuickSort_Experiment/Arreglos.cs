using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_Experiment
{
    public class Arreglo
    {

        int[] arreglo { get; set; }
        int[] arregloA { get; set; }
        int[] arregloD { get; set; }
        private Random random;
        private QuickSort qs;

        public Arreglo()
        {
            qs = new QuickSort();
            random = new Random();
            
        }

        public int[] ArregloDesorganizado(int valor)
        {
            arreglo = new int[valor];
            arregloA = new int[valor];
            arregloD = new int[valor];
            for (int i = 0; i < valor; i++)
            {
                arreglo[i] = random.Next(1, 1000000000);
                arregloA[i] = arreglo[i];
                arregloD[i] =arreglo[i];
            }
            return arreglo;
        }

        public int[] ArregloAscendente()
        {
            qs.RandomizedQS(arregloA, 0, arregloA.Length - 1);
            return arregloA;
        }

        public int[] ArregloDescendente()
        {
            qs.RandomizedQS(arregloD, 0, arregloD.Length - 1);
            return arregloD;
        }
    }
}
