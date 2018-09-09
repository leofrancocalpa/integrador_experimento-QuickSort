using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_Experiment
{
    public class QuickSort
    {
        public QuickSort()
        {

        }

        //Quick Sort no Randomizado
        public int QuickSortMethod(int[] array, int left, int right)
        {
            try
            {
                int count = 0;
                if (left < right)
                {
                    int pivot = Partition(array, left, right);
                    QuickSortMethod(array, left, pivot - 1);
                    QuickSortMethod(array, pivot + 1, right);
                }

                return count;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return 0;
            }
            
        }

        public int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left-1;
            for(int j=left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            int temp1 = array[i + 1];
            array[i + 1] = array[right];
            array[right] = temp1;
            return i + 1;
        }

        //Quic Sort Randomizado
        public int RandomizedQS(int[] array, int left, int right)
        {
            int count = 0;
            if (left < right)
            {
                int pivot = RandomizedPartition(array, left, right);
                RandomizedQS(array, left, pivot - 1);
                RandomizedQS(array, pivot + 1, right);
            }
            return count;
        }

        public int RandomizedPartition(int[] array, int left, int right)
        {
            Random random = new Random();
            int i = random.Next(left, right);
            int temp = array[right];
            array[right] = array[i];
            array[i] = temp;
            return Partition(array, left, right);
        }
    }
}
