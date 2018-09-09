using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_Experiment
{
    class Arreglo
    {

        private int[] arregloEsperado { get; set; }
        private Random random;

        public int[] ArregloDesorganizado(int valor)
        {
            random = new Random();
            for (int i = 0; i <= valor; i++)
            {
                arregloEsperado[i] = random.Next(1, 1000000000);
            }

            return arregloEsperado;
        }

        public int[] ArregloAscendente(int valor)
        {
            int num0 = 0;
            int num1 = 1;
            bool primer = false;
            random = new Random();
            for (int i = 0; i <= valor; i++)
            {
                num0 = random.Next(1, 1000000000);
                num1 = random.Next(1, 1000000000);

                if (primer == false)
                {
                    arregloEsperado[i] = num0;
                    primer = true;
                }
                else
                {


                    if (num0 <= num1)
                    {
                        arregloEsperado[i] = num0;
                    }
                    else if (num1 < num0)
                    {
                        arregloEsperado[i] = num1;
                    }
                }
            }

            return arregloEsperado;
        }

        public int[] ArregloDescendente(int valor)
        {
            random = new Random();
            for (int i = 0; i <= valor; i++)
            {
                int aleatorio = random.Next(1, 1000000000);
                int num0 = random.Next(1, 250000000);
                int num1 = random.Next(num0, 500000000);
                int num2 = random.Next(num1, 750000000);
                int num3 = random.Next(num2, 1000000000); ;
                if (num0 < num1)
                {

                    arregloEsperado[i] = aleatorio;
                }

            }
            return arregloEsperado;
        }
    }
}
