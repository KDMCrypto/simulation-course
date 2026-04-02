namespace lab8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            start_button = new Button();
            intensity = new NumericUpDown();
            T_mod = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            N_start = new NumericUpDown();
            button1 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)intensity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)T_mod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)N_start).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // start_button
            // 
            start_button.BackColor = Color.Green;
            start_button.FlatStyle = FlatStyle.Flat;
            start_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            start_button.ForeColor = SystemColors.Window;
            start_button.Location = new Point(913, 715);
            start_button.Name = "start_button";
            start_button.Size = new Size(112, 43);
            start_button.TabIndex = 0;
            start_button.Text = "Старт";
            start_button.UseVisualStyleBackColor = false;
            start_button.Click += start_button_Click;
            // 
            // intensity
            // 
            intensity.DecimalPlaces = 1;
            intensity.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            intensity.Location = new Point(285, 95);
            intensity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            intensity.Name = "intensity";
            intensity.Size = new Size(101, 31);
            intensity.TabIndex = 1;
            intensity.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // T_mod
            // 
            T_mod.Location = new Point(285, 32);
            T_mod.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            T_mod.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            T_mod.Name = "T_mod";
            T_mod.Size = new Size(101, 31);
            T_mod.TabIndex = 2;
            T_mod.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 3;
            label1.Text = "Интенсивность:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 31);
            label2.Name = "label2";
            label2.Size = new Size(261, 28);
            label2.TabIndex = 4;
            label2.Text = "Время моделирования, c";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(-3, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1200, 2);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(491, 35);
            label3.Name = "label3";
            label3.Size = new Size(174, 28);
            label3.TabIndex = 7;
            label3.Text = "Число запусков:";
            // 
            // N_start
            // 
            N_start.Location = new Point(671, 36);
            N_start.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            N_start.Name = "N_start";
            N_start.Size = new Size(102, 31);
            N_start.TabIndex = 6;
            N_start.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(989, 12);
            button1.Name = "button1";
            button1.Size = new Size(40, 34);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(23, 171);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(671, 587);
            chart1.TabIndex = 9;
            chart1.Text = "chart1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(716, 171);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(309, 229);
            listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 793);
            Controls.Add(listBox1);
            Controls.Add(chart1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(N_start);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(T_mod);
            Controls.Add(intensity);
            Controls.Add(start_button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)intensity).EndInit();
            ((System.ComponentModel.ISupportInitialize)T_mod).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)N_start).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start_button;
        private NumericUpDown intensity;
        private NumericUpDown T_mod;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private NumericUpDown N_start;
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ListBox listBox1;
    }
}
