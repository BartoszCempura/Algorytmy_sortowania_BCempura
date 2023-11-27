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

            public Generator(int size)
            {
                this.size = size;
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
            int max = size;

            for (int i = 0; i < size; ++i)
            {
                array[i] = max;
                max--;
            }          
        }


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
    

