using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy_sortowania_BCempura
{
    internal class QuickSort : IQuickSort
    {
        public void Sort(int[] array,int begin,int end) 
        {
            int x = begin;
            int y = end;
            int pivot = array[(x+y)/2];

            while (x < y) 
            {
                while (array[x] < pivot)
                {
                    x++;
                }
                while (array[y] > pivot)
                {
                    y--;
                }

                if (x <= y)
                {
                    int tmp = array[x];
                    array[x++] = array[y];
                    array[y--] = tmp;
                }

            }
            if (begin < y)
            {
                Sort(array, begin, y);
            }
            if (x < end)
            {
                Sort(array, x, end);
            }
        }  

public void Sort(int[] array) 
        {
            Sort(array, 0, array.Length - 1);
        
        }


    }
}
