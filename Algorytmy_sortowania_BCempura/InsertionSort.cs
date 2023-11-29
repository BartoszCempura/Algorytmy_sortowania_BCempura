using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy_sortowania_BCempura
{
    internal class InsertionSort
    {
       public void Sort(int[] array)
        {
            int x = array.Length;
            int current;
            int comparedIndex;

            for (int i= 1; i < x; i++) 
            { 
            current = array[i];
            comparedIndex = i;
               
                while (comparedIndex > 0 && current < array[comparedIndex - 1]) 
                {
                    array[comparedIndex] = array[comparedIndex - 1];
                    comparedIndex--;
                }
                array[comparedIndex] = current;
            }


        }



    }
}
