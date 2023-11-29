using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorytmy_sortowania_BCempura
{
    internal class BubbleSort
    {

        public void Sort(int[] array) 
        {

            int x = array.Length;

            //zakomentowane mamy optymalizacje dla algorytmu
            //bool swapped;

           // do

           // {  swapped = false;

                for (int i = 0; i < (x - 1); ++i)
                {

                    for (int j = 0; j < (x-i-1); ++j)

                    if (array[j] > array[j+1])
                    {
                        var tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;

                      //  swapped = true; 
                    }

                }     
            
            
           // } while (swapped);   

            

        
        }

        //ten kod się powtarza - nie powinno tak być
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
