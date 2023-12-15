namespace Algorytmy_sortowania_BCempura
{
    partial class Algorytmy_sortowania_BCempura
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Sortuj = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Random = new System.Windows.Forms.Button();
            this.Ascending = new System.Windows.Forms.Button();
            this.Descending = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DisplayValue = new System.Windows.Forms.CheckBox();
            this.Ostrzeżenie = new System.Windows.Forms.TextBox();
            this.Komunikat_generator = new System.Windows.Forms.TextBox();
            this.WybórSort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(42, 235);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 79);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(669, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(103, 264);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Sortuj
            // 
            this.Sortuj.Location = new System.Drawing.Point(63, 325);
            this.Sortuj.Name = "Sortuj";
            this.Sortuj.Size = new System.Drawing.Size(75, 23);
            this.Sortuj.TabIndex = 2;
            this.Sortuj.Text = "Sortuj";
            this.Sortuj.UseVisualStyleBackColor = true;
            this.Sortuj.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(42, 53);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(63, 79);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(75, 23);
            this.Random.TabIndex = 5;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Generój_Click);
            // 
            // Ascending
            // 
            this.Ascending.Location = new System.Drawing.Point(63, 108);
            this.Ascending.Name = "Ascending";
            this.Ascending.Size = new System.Drawing.Size(75, 23);
            this.Ascending.TabIndex = 6;
            this.Ascending.Text = "Ascending";
            this.Ascending.UseVisualStyleBackColor = true;
            this.Ascending.Click += new System.EventHandler(this.Ascending_Click);
            // 
            // Descending
            // 
            this.Descending.Location = new System.Drawing.Point(63, 137);
            this.Descending.Name = "Descending";
            this.Descending.Size = new System.Drawing.Size(75, 23);
            this.Descending.TabIndex = 8;
            this.Descending.Text = "Descending";
            this.Descending.UseVisualStyleBackColor = true;
            this.Descending.Click += new System.EventHandler(this.Descending_Click);
            // 
            // chart1
            // 
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(198, 59);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(448, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            title2.Name = "Title1";
            title2.Visible = false;
            this.chart1.Titles.Add(title2);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(198, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(448, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DisplayValue
            // 
            this.DisplayValue.AutoSize = true;
            this.DisplayValue.Location = new System.Drawing.Point(669, 69);
            this.DisplayValue.Name = "DisplayValue";
            this.DisplayValue.Size = new System.Drawing.Size(103, 17);
            this.DisplayValue.TabIndex = 11;
            this.DisplayValue.Text = "Wyświetl Dane?";
            this.DisplayValue.UseVisualStyleBackColor = true;
            this.DisplayValue.CheckedChanged += new System.EventHandler(this.DisplayValue_CheckedChanged);
            // 
            // Ostrzeżenie
            // 
            this.Ostrzeżenie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ostrzeżenie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ostrzeżenie.Location = new System.Drawing.Point(666, 30);
            this.Ostrzeżenie.Multiline = true;
            this.Ostrzeżenie.Name = "Ostrzeżenie";
            this.Ostrzeżenie.ReadOnly = true;
            this.Ostrzeżenie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ostrzeżenie.Size = new System.Drawing.Size(106, 35);
            this.Ostrzeżenie.TabIndex = 12;
            this.Ostrzeżenie.Text = "Duże zbiory mogą\r\nbyć czasochłonne";
            this.Ostrzeżenie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ostrzeżenie.TextChanged += new System.EventHandler(this.Ostrzeżenie_TextChanged);
            // 
            // Komunikat_generator
            // 
            this.Komunikat_generator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Komunikat_generator.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Komunikat_generator.Location = new System.Drawing.Point(27, 28);
            this.Komunikat_generator.Multiline = true;
            this.Komunikat_generator.Name = "Komunikat_generator";
            this.Komunikat_generator.ReadOnly = true;
            this.Komunikat_generator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Komunikat_generator.Size = new System.Drawing.Size(148, 141);
            this.Komunikat_generator.TabIndex = 13;
            this.Komunikat_generator.Text = "Generator liczb";
            this.Komunikat_generator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WybórSort
            // 
            this.WybórSort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WybórSort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WybórSort.Location = new System.Drawing.Point(27, 185);
            this.WybórSort.Multiline = true;
            this.WybórSort.Name = "WybórSort";
            this.WybórSort.ReadOnly = true;
            this.WybórSort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WybórSort.Size = new System.Drawing.Size(148, 174);
            this.WybórSort.TabIndex = 14;
            this.WybórSort.Text = "Zaznacz którego algorytmu\r\nczas wykonania chcesz sprawdzić";
            this.WybórSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WybórSort.TextChanged += new System.EventHandler(this.WybórSort_TextChanged);
            // 
            // Algorytmy_sortowania_BCempura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.Sortuj);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.WybórSort);
            this.Controls.Add(this.Descending);
            this.Controls.Add(this.Ascending);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Komunikat_generator);
            this.Controls.Add(this.Ostrzeżenie);
            this.Controls.Add(this.DisplayValue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox1);
            this.Name = "Algorytmy_sortowania_BCempura";
            this.Text = "Algorytmy_sortowania_BCempura";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Sortuj;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button Ascending;
        private System.Windows.Forms.Button Descending;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox DisplayValue;
        private System.Windows.Forms.TextBox Ostrzeżenie;
        private System.Windows.Forms.TextBox Komunikat_generator;
        private System.Windows.Forms.TextBox WybórSort;
    }
}

