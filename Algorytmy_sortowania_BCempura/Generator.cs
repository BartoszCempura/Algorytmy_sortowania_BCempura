using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytmy_sortowania_BCempura
{
    internal class Generator
    {

            private int size;
            private int[] array;
            private int asc = 0;
            private int dsc = 0;

            public Generator(int x)
            {
                this.size = x;
                array = new int[size];
            }

            public void random()
        {
            Random random = new Random();

            for (int i = 0; i < size; ++i)

            {
            array[i] = random.Next(0, 1001);
            }

        }
        public void Ascending()
        {
            Random ascending = new Random();

            asc = ascending.Next(0, 20);

            for (int i = 0; i < size; ++i)
            {
                array[i] = asc;
                asc = ascending.Next(asc,asc+20);

            }           
        }

        public void Descending()
        {
            Random descending = new Random();

            dsc = descending.Next(0, 5);

            for (int i = 0; i < size; ++i)
            {
                array[(size-1) - i] = dsc;
                dsc = descending.Next(dsc, dsc + 5);

            }
        }
        /*
        //kod generuje wartości od size i co jeden w dół, powyżej jest bardziej losowy
        public void Descending() 
        {
            int max = size;

            for (int i = 0; i < size; ++i)
            {
                array[i] = max;
                max--;
            }          
        }
*/

        public int[] GetArray()
        {
            return array;
        }

        public int GetSize()
        {
            return size;
        }

    }

}
    

