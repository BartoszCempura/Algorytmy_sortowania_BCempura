using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy_sortowania_BCempura
{
    internal interface ISort
    {
       
            void Sort(int[] array);
       
    
    }

    internal interface IQuickSort : ISort
    {
            void Sort(int[] array, int begin, int end);
    }


    
}
