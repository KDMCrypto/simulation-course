namespace lab2
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
            button1 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button2 = new Button();
            Step_t = new NumericUpDown();
            Step_space = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            max_t = new NumericUpDown();
            label4 = new Label();
            thickness = new NumericUpDown();
            label5 = new Label();
            t_right = new NumericUpDown();
            label6 = new Label();
            t_left = new NumericUpDown();
            label7 = new Label();
            T_door = new NumericUpDown();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Step_t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Step_space).BeginInit();
            ((System.ComponentModel.ISupportInitialize)max_t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thickness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)t_right).BeginInit();
            ((System.ComponentModel.ISupportInitialize)t_left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)T_door).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(765, 50);
            button1.Name = "button1";
            button1.Size = new Size(119, 51);
            button1.TabIndex = 0;
            button1.Text = "Старт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chart1
            // 
            chart1.BackColor = Color.Beige;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(25, 393);
            chart1.Name = "chart1";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1019, 610);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // button2
            // 
            button2.Location = new Point(925, 52);
            button2.Name = "button2";
            button2.Size = new Size(119, 51);
            button2.TabIndex = 2;
            button2.Text = "Стоп";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Step_t
            // 
            Step_t.DecimalPlaces = 5;
            Step_t.Location = new Point(240, 50);
            Step_t.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            Step_t.Name = "Step_t";
            Step_t.Size = new Size(112, 31);
            Step_t.TabIndex = 3;
            Step_t.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // Step_space
            // 
            Step_space.DecimalPlaces = 5;
            Step_space.Location = new Point(240, 100);
            Step_space.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            Step_space.Name = "Step_space";
            Step_space.Size = new Size(112, 31);
            Step_space.TabIndex = 4;
            Step_space.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 52);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 5;
            label1.Text = "Шаг по времени";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 102);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 6;
            label2.Text = "Шаг по пространству";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 154);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 8;
            label3.Text = "Время моделирования";
            // 
            // max_t
            // 
            max_t.DecimalPlaces = 1;
            max_t.Location = new Point(240, 152);
            max_t.Maximum = new decimal(new int[] { 864000, 0, 0, 0 });
            max_t.Name = "max_t";
            max_t.Size = new Size(112, 31);
            max_t.TabIndex = 7;
            max_t.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 206);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 10;
            label4.Text = "Толщина пластины";
            // 
            // thickness
            // 
            thickness.DecimalPlaces = 4;
            thickness.Location = new Point(240, 200);
            thickness.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            thickness.Name = "thickness";
            thickness.Size = new Size(112, 31);
            thickness.TabIndex = 9;
            thickness.Value = new decimal(new int[] { 2, 0, 0, 65536 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 154);
            label5.Name = "label5";
            label5.Size = new Size(180, 25);
            label5.TabIndex = 12;
            label5.Text = "Температура справа";
            // 
            // t_right
            // 
            t_right.DecimalPlaces = 1;
            t_right.Location = new Point(595, 152);
            t_right.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            t_right.Minimum = new decimal(new int[] { 267, 0, 0, int.MinValue });
            t_right.Name = "t_right";
            t_right.Size = new Size(112, 31);
            t_right.TabIndex = 11;
            t_right.Value = new decimal(new int[] { 30, 0, 0, int.MinValue });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 52);
            label6.Name = "label6";
            label6.Size = new Size(172, 25);
            label6.TabIndex = 14;
            label6.Text = "Температура слева:";
            // 
            // t_left
            // 
            t_left.DecimalPlaces = 1;
            t_left.Location = new Point(595, 50);
            t_left.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            t_left.Minimum = new decimal(new int[] { 267, 0, 0, int.MinValue });
            t_left.Name = "t_left";
            t_left.Size = new Size(112, 31);
            t_left.TabIndex = 13;
            t_left.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 102);
            label7.Name = "label7";
            label7.Size = new Size(199, 25);
            label7.TabIndex = 16;
            label7.Text = "Температура пластины";
            // 
            // T_door
            // 
            T_door.DecimalPlaces = 1;
            T_door.Location = new Point(595, 100);
            T_door.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            T_door.Minimum = new decimal(new int[] { 267, 0, 0, int.MinValue });
            T_door.Name = "T_door";
            T_door.Size = new Size(112, 31);
            T_door.TabIndex = 15;
            T_door.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(284, 258);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(502, 129);
            listBox1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1071, 1015);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(T_door);
            Controls.Add(label6);
            Controls.Add(t_left);
            Controls.Add(label5);
            Controls.Add(t_right);
            Controls.Add(label4);
            Controls.Add(thickness);
            Controls.Add(label3);
            Controls.Add(max_t);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Step_space);
            Controls.Add(Step_t);
            Controls.Add(button2);
            Controls.Add(chart1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Step_t).EndInit();
            ((System.ComponentModel.ISupportInitialize)Step_space).EndInit();
            ((System.ComponentModel.ISupportInitialize)max_t).EndInit();
            ((System.ComponentModel.ISupportInitialize)thickness).EndInit();
            ((System.ComponentModel.ISupportInitialize)t_right).EndInit();
            ((System.ComponentModel.ISupportInitialize)t_left).EndInit();
            ((System.ComponentModel.ISupportInitialize)T_door).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button2;
        private NumericUpDown Step_t;
        private NumericUpDown Step_space;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown max_t;
        private Label label4;
        private NumericUpDown thickness;
        private Label label5;
        private NumericUpDown t_right;
        private Label label6;
        private NumericUpDown t_left;
        private Label label7;
        private NumericUpDown T_door;
        private ListBox listBox1;
    }
}
