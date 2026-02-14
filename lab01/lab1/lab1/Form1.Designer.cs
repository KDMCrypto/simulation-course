namespace lab1
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Start_batton = new Button();
            button2 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label2 = new Label();
            Label_Speed = new Label();
            Label_Size = new Label();
            Label_Weight = new Label();
            Height = new NumericUpDown();
            Angle = new NumericUpDown();
            Speed = new NumericUpDown();
            Size = new NumericUpDown();
            Weight = new NumericUpDown();
            timer1 = new System.Windows.Forms.Timer(components);
            Step = new NumericUpDown();
            label3 = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Angle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Speed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Weight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Step).BeginInit();
            SuspendLayout();
            // 
            // Start_batton
            // 
            Start_batton.Location = new Point(583, 86);
            Start_batton.Name = "Start_batton";
            Start_batton.Size = new Size(144, 51);
            Start_batton.TabIndex = 0;
            Start_batton.Text = "Старт";
            Start_batton.UseVisualStyleBackColor = true;
            Start_batton.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(761, 86);
            button2.Name = "button2";
            button2.Size = new Size(135, 51);
            button2.TabIndex = 1;
            button2.Text = "Стоп";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Close_button_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(35, 400);
            chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(954, 559);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 53);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 8;
            label1.Text = "Высота:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 96);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 9;
            label2.Text = "Угол:";
            // 
            // Label_Speed
            // 
            Label_Speed.AutoSize = true;
            Label_Speed.Location = new Point(35, 144);
            Label_Speed.Name = "Label_Speed";
            Label_Speed.Size = new Size(93, 25);
            Label_Speed.TabIndex = 10;
            Label_Speed.Text = "Скорость:";
            // 
            // Label_Size
            // 
            Label_Size.AutoSize = true;
            Label_Size.Location = new Point(294, 53);
            Label_Size.Name = "Label_Size";
            Label_Size.Size = new Size(76, 25);
            Label_Size.TabIndex = 11;
            Label_Size.Text = "Размер:";
            // 
            // Label_Weight
            // 
            Label_Weight.AutoSize = true;
            Label_Weight.Location = new Point(294, 102);
            Label_Weight.Name = "Label_Weight";
            Label_Weight.Size = new Size(43, 25);
            Label_Weight.TabIndex = 12;
            Label_Weight.Text = "Вес:";
            // 
            // Height
            // 
            Height.DecimalPlaces = 2;
            Height.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            Height.Location = new Point(152, 53);
            Height.Name = "Height";
            Height.Size = new Size(109, 31);
            Height.TabIndex = 13;
            // 
            // Angle
            // 
            Angle.DecimalPlaces = 2;
            Angle.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            Angle.Location = new Point(152, 97);
            Angle.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            Angle.Name = "Angle";
            Angle.Size = new Size(109, 31);
            Angle.TabIndex = 14;
            Angle.Value = new decimal(new int[] { 45, 0, 0, 0 });
            // 
            // Speed
            // 
            Speed.DecimalPlaces = 2;
            Speed.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            Speed.Location = new Point(152, 144);
            Speed.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            Speed.Name = "Speed";
            Speed.Size = new Size(109, 31);
            Speed.TabIndex = 15;
            Speed.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // Size
            // 
            Size.DecimalPlaces = 2;
            Size.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            Size.Location = new Point(397, 53);
            Size.Name = "Size";
            Size.Size = new Size(109, 31);
            Size.TabIndex = 16;
            Size.Value = new decimal(new int[] { 15, 0, 0, 65536 });
            // 
            // Weight
            // 
            Weight.DecimalPlaces = 2;
            Weight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            Weight.Location = new Point(397, 97);
            Weight.Name = "Weight";
            Weight.Size = new Size(109, 31);
            Weight.TabIndex = 17;
            Weight.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Step
            // 
            Step.DecimalPlaces = 4;
            Step.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            Step.Location = new Point(397, 142);
            Step.Name = "Step";
            Step.Size = new Size(109, 31);
            Step.TabIndex = 18;
            Step.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 144);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 19;
            label3.Text = "Шаг";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(35, 204);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(471, 179);
            listBox1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 949);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(Step);
            Controls.Add(Weight);
            Controls.Add(Size);
            Controls.Add(Speed);
            Controls.Add(Angle);
            Controls.Add(Height);
            Controls.Add(Label_Weight);
            Controls.Add(Label_Size);
            Controls.Add(Label_Speed);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chart1);
            Controls.Add(button2);
            Controls.Add(Start_batton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Height).EndInit();
            ((System.ComponentModel.ISupportInitialize)Angle).EndInit();
            ((System.ComponentModel.ISupportInitialize)Speed).EndInit();
            ((System.ComponentModel.ISupportInitialize)Size).EndInit();
            ((System.ComponentModel.ISupportInitialize)Weight).EndInit();
            ((System.ComponentModel.ISupportInitialize)Step).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start_batton;
        private Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
        private Label label2;
        private Label Label_Speed;
        private Label Label_Size;
        private Label Label_Weight;
        private NumericUpDown Height;
        private NumericUpDown Angle;
        private NumericUpDown Speed;
        private NumericUpDown Size;
        private NumericUpDown Weight;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown Step;
        private Label label3;
        private ListBox listBox1;
    }
}
