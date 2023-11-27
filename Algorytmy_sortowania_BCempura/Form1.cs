using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        

        public Form1()
        {
            InitializeComponent();
            array = new int[0];
            DisplayValues();
            InitializeCheckboxes();
        }
        private void InitializeCheckboxes()
        {
            checkedListBox1.Items.Add("Checkbox 1");
            checkedListBox1.Items.Add("Checkbox 2");
            checkedListBox1.Items.Add("Checkbox 3");
            checkedListBox1.Items.Add("Checkbox 4");
            checkedListBox1.Items.Add("Checkbox 5");
        }
 

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayValues()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(array.Select(x => x.ToString()).ToArray());
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //już działają oba - teraz rozkmiń jak to ma być dalej ułożone i jak połaczyć to z checklistbox
            SelectionSort selectionSort = new SelectionSort();
            selectionSort.Sort(array);
             //BubbleSort bubbleSort = new BubbleSort();
              //bubbleSort.Sort(array);

           
            DisplayValues();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void Generój_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDown1.Value;
            Generator generator = new Generator(size);
            generator.random();

            array = generator.GetArray();
            DisplayValues();
        }

        private void Ascending_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDown1.Value;
            Generator generator1 = new Generator(size);
            generator1.Ascending();

            array = generator1.GetArray();
            DisplayValues();
        }    
        private void Descending_Click(object sender, EventArgs e)
        {
            int size = (int)numericUpDown1.Value;
            Generator generator2 = new Generator(size);
            generator2.Descending();

            array = generator2.GetArray();
            DisplayValues();
        }
    }
}
