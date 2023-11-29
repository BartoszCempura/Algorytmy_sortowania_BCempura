using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;



namespace Algorytmy_sortowania_BCempura
{
    public partial class Form1 : Form
    {

        private int[] array;

        private bool useBubbleSort = false;
        private bool useSelectionSort = false;
        private bool useQuickSort = false;


        public Form1()
        {
            InitializeComponent();
            array = new int[0];
            DisplayValues();
            InitializeCheckboxes();
        }
        private void InitializeCheckboxes()
        {
            checkedListBox1.Items.Add("BubbleSort");
            checkedListBox1.Items.Add("SelectionSort");
            checkedListBox1.Items.Add("QuickSort");
           // checkedListBox1.Items.Add("Checkbox 4");
            //checkedListBox1.Items.Add("Checkbox 5");
        }
 

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            useBubbleSort = checkedListBox1.GetItemChecked(0);
            useSelectionSort = checkedListBox1.GetItemChecked(1);
            useQuickSort = checkedListBox1.GetItemChecked(2);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayValues()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(array.Select(x => x.ToString()).ToArray());
        }

        //każdy kod powinien być używany tylko raz. Nie powinny powielać się linnie kodu
        private void button1_Click(object sender, EventArgs e)
        {
            if (useBubbleSort)
            {
                BubbleSort bubbleSort = new BubbleSort();
                int[]tmp1 = new int[array.Length];
                //Array.Copy(array, tmp1, array.Length);
                tmp1 = (int[])array.Clone(); //alternatywa dla kodu powyżej, działa dla dowolnych typów zmiennych ale trzeba rzutować 
                Stopwatch stopwatch1 = new Stopwatch();
                stopwatch1.Start();
                bubbleSort.Sort(tmp1);
                stopwatch1.Stop();
                MessageBox.Show("BubbleSort Zakończony." +
                                "\nWartość pierwsza to "+ tmp1[0] +
                                "\nWartość ostatnia to " + tmp1[tmp1.Length-1] +
                                "\nCzas trwania: " + stopwatch1.Elapsed);
            }
            //sortowanie dla wartości powyżej 100k trwa bardzo długo ale nie ma potzreby tego obliczać
            if (useSelectionSort)
            {
                SelectionSort selectionSort = new SelectionSort();
                int[] tmp2 = new int[array.Length];
                Array.Copy(array, tmp2, array.Length);
                Stopwatch stopwatch2 = new Stopwatch();
                stopwatch2.Start();
                selectionSort.Sort(tmp2);
                stopwatch2.Stop();
                MessageBox.Show("SelectionSort Zakończony." +
                                "\nWartość pierwsza to " + tmp2[0] +
                                "\nWartość ostatnia to " + tmp2[tmp2.Length - 1] +
                                "\nCzas trwania: " + stopwatch2.Elapsed);
            }
            if (useQuickSort)
            {
                QuickSort quickSort = new QuickSort();
                int[] tmp3 = new int[array.Length];
                Array.Copy(array, tmp3, array.Length);
                Stopwatch stopwatch3 = new Stopwatch();
                stopwatch3.Start();
                quickSort.Sort(tmp3, 0, tmp3.Length);
                stopwatch3.Stop();
                MessageBox.Show("SelectionSort Zakończony." +
                                "\nWartość pierwsza to " + tmp3[0] +
                                "\nWartość ostatnia to " + tmp3[tmp3.Length - 1] +
                                "\nCzas trwania: " + stopwatch3.Elapsed);
            }

            DisplayValues();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void Generój_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value;
            Generator generator = new Generator(x);
            generator.random();

            array = generator.GetArray();
            DisplayValues();
        }

        private void Ascending_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value;
            Generator generator1 = new Generator(x);
            generator1.Ascending();

            array = generator1.GetArray();
            DisplayValues();
        }    
        private void Descending_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown1.Value;
            Generator generator2 = new Generator(x);
            generator2.Descending();

            array = generator2.GetArray();
            DisplayValues();
        }
    }
}
