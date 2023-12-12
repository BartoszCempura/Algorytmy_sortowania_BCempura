﻿using System;
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
    public partial class Form1 : Form
    {

        private int[] array;
        int x;


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
            checkedListBox1.Items.Add("InsertionSort");
            checkedListBox1.Items.Add("MergeSort");
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
            chart1.Series.Clear();

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

            string filename = $"{x}";

            foreach (var x in selectedAlgorithms)
            {
                int[] sortedArray = (int[])array.Clone();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                x.Sort(sortedArray);
                stopwatch.Stop();
                
                AddDataPoint(chart1, x.GetType().Name, stopwatch.Elapsed.TotalMilliseconds);
                DataToTxt.SaveToFile(filename, x.GetType().Name, stopwatch.Elapsed.TotalMilliseconds, selectedAlgorithms.Count());
            }

            foreach (var series in chart1.Series)
            {
                foreach (var point in series.Points)
                {
                    point.Label = point.YValues[0].ToString()+" ms";
                    point.Font= new Font(point.Font, FontStyle.Bold);
                    point.LabelForeColor = Color.Black; 
                    point.LabelBackColor = Color.Transparent; 
                }
            }

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void Generój_Click(object sender, EventArgs e)
        {
            x = (int)numericUpDown1.Value;
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

        private void chart1_Click(object sender, EventArgs e)
        {

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

        
    }
}
