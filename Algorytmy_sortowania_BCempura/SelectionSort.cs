using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytmy_sortowania_BCempura
{
    internal class SelectionSort
    {

        public void Sort(int[] array)
        {
            int x = array.Length;

            for (int i = 0; i < (x - 1); ++i)
            {
                int indexofthelowest = i;

                for (int j = i + 1; j < x; ++j)
                {
                    if (array[j] < array[indexofthelowest])
                        indexofthelowest = j;
                }

                if (indexofthelowest != i) 
                { 
                    var tmp = array[indexofthelowest];
                    array[indexofthelowest] = array[i];
                    array[i] = tmp;
                }

                 
            }

        }

        //ten kod się powtarza - nie powinno tak być - 
        public void Drukuj(ListBox listBox, int[] array)
        {
            listBox.Items.Clear();

            foreach (var element in array)
            {
                listBox.Items.Add(element.ToString());
            }

        }




    }
}

