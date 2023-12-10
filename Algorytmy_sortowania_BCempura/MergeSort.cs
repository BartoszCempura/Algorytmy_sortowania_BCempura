using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy_sortowania_BCempura
{
    internal class MergeSort : ISort
    {
        private int[] arrayExtra;
        public void Sort(int[] array) 
        {
            arrayExtra = new int[array.Length];
            mergeSort(array, 0, array.Length - 1);

        }  

        private void mergeSort(int[] array, int from, int to)
        {
            if (from < to)
            { 
                int middle = (from + to) / 2;
                mergeSort(array, from, middle);
                mergeSort(array, middle + 1, to);
                merge(array, from, middle, to);
            }
        }

        private void merge(int[] array, int from, int middle, int to)
        { 
        for (int i = from; i <= to;i++) 
            {
                arrayExtra[i] = array[i];   
            }

            int signpost1 = from;
            int signpost2 = middle +1;
            int current = from;

        while (signpost1 <= middle && signpost2 <= to)
            { 
            if (arrayExtra[signpost1] <= arrayExtra[signpost2])
                {
                    array[current] = arrayExtra[signpost1];
                    signpost1++;
                }
                else 
                {
                    array[current] = arrayExtra[signpost2];
                    signpost2++;
                }
                current++;                 
                     
            }
       while (signpost1 <= middle)
            {
                array[current]= arrayExtra[signpost1];
                current++;
                signpost1++;
            }
        
        }



    }
}
