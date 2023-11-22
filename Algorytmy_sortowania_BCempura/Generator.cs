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
            array[i] = random.Next(); ;
            }

        }
        public void Ascending()
        {
            Random ascending = new Random();

            asc = ascending.Next();

            for (int i = 0; i < size; ++i)

            {
                array[i] = asc;
                asc++;

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
    

