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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;



namespace Algorytmy_sortowania_BCempura
{
    public partial class Algorytmy_sortowania_BCempura : Form
    {

        private int[] array;
        int rozmiar_tablicy;


        public Algorytmy_sortowania_BCempura()
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
            checkedListBox1.Items.Add("InsertionSort");
            checkedListBox1.Items.Add("MergeSort");
        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
               
                string separator = " ";
                string content = string.Join(separator, listBox1.Items.Cast<object>());

                
                Clipboard.SetText(content);
            }

            MessageBox.Show("Tekst został skopiowany do schowka.");
        }


        private void DisplayValues()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(array.Select(rozmiar_tablicy => rozmiar_tablicy.ToString()).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           chart1.Series.Clear();

            if (rozmiar_tablicy != 0)
            {
                List<ISort> selectedAlgorithms = new List<ISort>();

                if (checkedListBox1.GetItemChecked(0))
                {
                    selectedAlgorithms.Add(new BubbleSort());
                }

                if (checkedListBox1.GetItemChecked(1))
                {
                    selectedAlgorithms.Add(new SelectionSort());
                }

                if (checkedListBox1.GetItemChecked(2))
                {
                    selectedAlgorithms.Add(new QuickSort());
                }

                if (checkedListBox1.GetItemChecked(3))
                {
                    selectedAlgorithms.Add(new InsertionSort());
                }

                if (checkedListBox1.GetItemChecked(4))
                {
                    selectedAlgorithms.Add(new MergeSort());
                }

                if (selectedAlgorithms.Count == 0)
                {
                    MessageBox.Show("Wybierz przynajmniej jeden algorytm");
                    return;
                }              

                foreach (var algorithm in selectedAlgorithms)
                {
                    int[] sortedArray = (int[])array.Clone();
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    algorithm.Sort(sortedArray);
                    stopwatch.Stop();

                    AddDataPoint(chart1, algorithm.GetType().Name, stopwatch.Elapsed.TotalMilliseconds);
                    DataToTxt.SaveToFile(rozmiar_tablicy.ToString(), algorithm.GetType().Name, stopwatch.Elapsed.TotalMilliseconds, selectedAlgorithms.Count());
                }

                foreach (var series in chart1.Series)
                {
                    foreach (var point in series.Points)
                    {
                        point.Label = point.YValues[0].ToString() + " ms";
                        point.Font = new Font(point.Font, FontStyle.Bold);
                        point.LabelForeColor = Color.Black;
                        point.LabelBackColor = Color.Transparent;
                    }
                }

                Sortuj.Enabled = false;
            }
            else
            {
                MessageBox.Show("Podaj wartośc większą od 0");
            }
        }


        private void DisplayValue_CheckedChanged(object sender, EventArgs e)
        {
            if (DisplayValue.Checked)
            {
                DisplayValues();
            }
            else
            {
                listBox1.Items.Clear();
            }
        }

        private void Generój_Click(object sender, EventArgs e)
        {

            DisplayValue.Checked = false;

            Sortuj.Enabled = true;

            rozmiar_tablicy = (int)numericUpDown1.Value;
            Generator generator = new Generator(rozmiar_tablicy);
            generator.random();

            array = generator.GetArray();

            textBox1.Text = $"Obliczenia dla ciągu o {rozmiar_tablicy} elementach. Typ losowy. Kliknij Sortuj";
            chart1.Series.Clear();
       
        }

        private void Ascending_Click(object sender, EventArgs e)
        {

            DisplayValue.Checked = false;

            Sortuj.Enabled = true;

            rozmiar_tablicy = (int)numericUpDown1.Value;
            Generator generator1 = new Generator(rozmiar_tablicy);
            generator1.Ascending();

            array = generator1.GetArray();

            textBox1.Text = $"Obliczenia dla ciągu o {rozmiar_tablicy} elementach.Typ rosnący. Kliknij Sortuj";
            chart1.Series.Clear();
          
        }
        private void Descending_Click(object sender, EventArgs e)
        {
            DisplayValue.Checked = false;

            Sortuj.Enabled = true;

            rozmiar_tablicy = (int)numericUpDown1.Value;
            Generator generator2 = new Generator(rozmiar_tablicy);
            generator2.Descending();

            array = generator2.GetArray();

            textBox1.Text = $"Obliczenia dla ciągu o {rozmiar_tablicy} elementach. Typ malejący. Kliknij Sortuj";
            chart1.Series.Clear();
          
        }


        private void AddDataPoint(Chart chart, string algorithmName, double elapsedTime)
        {
            
            if (!chart.Series.Any(s => s.Name == algorithmName))
            {
                chart.Series.Add(new Series(algorithmName));
                chart.Series[algorithmName].ChartType = SeriesChartType.Bar; 
            }
       
           
            chart.Series[algorithmName].Points.AddXY(algorithmName, elapsedTime);
        }



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ostrzeżenie_TextChanged(object sender, EventArgs e)
        {

        }

        private void WybórSort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
