namespace lab7
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
            Start = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            numericUpDown7 = new NumericUpDown();
            numericUpDown8 = new NumericUpDown();
            numericUpDown9 = new NumericUpDown();
            save_button = new Button();
            log_Day = new Label();
            Days = new NumericUpDown();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Days).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.BackColor = Color.ForestGreen;
            Start.FlatStyle = FlatStyle.Flat;
            Start.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Start.ForeColor = SystemColors.Window;
            Start.Location = new Point(1304, 621);
            Start.Name = "Start";
            Start.Size = new Size(126, 45);
            Start.TabIndex = 0;
            Start.Text = "Старт";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(1387, 12);
            button2.Name = "button2";
            button2.Size = new Size(43, 37);
            button2.TabIndex = 1;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer_Tick;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Location = new Point(43, 48);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(73, 31);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 1;
            numericUpDown2.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.Location = new Point(137, 48);
            numericUpDown2.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(73, 31);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 1;
            numericUpDown3.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown3.Location = new Point(233, 48);
            numericUpDown3.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(73, 31);
            numericUpDown3.TabIndex = 4;
            numericUpDown3.Value = new decimal(new int[] { 4, 0, 0, 65536 });
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 1;
            numericUpDown4.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown4.Location = new Point(43, 109);
            numericUpDown4.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(73, 31);
            numericUpDown4.TabIndex = 7;
            numericUpDown4.Value = new decimal(new int[] { 2, 0, 0, 65536 });
            // 
            // numericUpDown5
            // 
            numericUpDown5.DecimalPlaces = 1;
            numericUpDown5.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown5.Location = new Point(137, 109);
            numericUpDown5.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(73, 31);
            numericUpDown5.TabIndex = 6;
            numericUpDown5.Value = new decimal(new int[] { 7, 0, 0, 65536 });
            // 
            // numericUpDown6
            // 
            numericUpDown6.DecimalPlaces = 1;
            numericUpDown6.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown6.Location = new Point(233, 109);
            numericUpDown6.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(73, 31);
            numericUpDown6.TabIndex = 5;
            numericUpDown6.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // numericUpDown7
            // 
            numericUpDown7.DecimalPlaces = 1;
            numericUpDown7.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown7.Location = new Point(43, 169);
            numericUpDown7.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new Size(73, 31);
            numericUpDown7.TabIndex = 10;
            numericUpDown7.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // numericUpDown8
            // 
            numericUpDown8.DecimalPlaces = 1;
            numericUpDown8.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown8.Location = new Point(137, 169);
            numericUpDown8.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown8.Name = "numericUpDown8";
            numericUpDown8.Size = new Size(73, 31);
            numericUpDown8.TabIndex = 9;
            numericUpDown8.Value = new decimal(new int[] { 3, 0, 0, 65536 });
            // 
            // numericUpDown9
            // 
            numericUpDown9.DecimalPlaces = 1;
            numericUpDown9.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown9.Location = new Point(233, 169);
            numericUpDown9.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown9.Name = "numericUpDown9";
            numericUpDown9.Size = new Size(73, 31);
            numericUpDown9.TabIndex = 8;
            numericUpDown9.Value = new decimal(new int[] { 2, 0, 0, 65536 });
            // 
            // save_button
            // 
            save_button.BackColor = Color.IndianRed;
            save_button.FlatStyle = FlatStyle.Flat;
            save_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            save_button.ForeColor = SystemColors.Window;
            save_button.Location = new Point(1304, 760);
            save_button.Name = "save_button";
            save_button.Size = new Size(126, 40);
            save_button.TabIndex = 11;
            save_button.Text = "Сохранить";
            save_button.UseVisualStyleBackColor = false;
            save_button.Click += save_button_Click;
            // 
            // log_Day
            // 
            log_Day.AutoSize = true;
            log_Day.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 204);
            log_Day.ForeColor = SystemColors.Window;
            log_Day.Location = new Point(12, 300);
            log_Day.Name = "log_Day";
            log_Day.Size = new Size(152, 60);
            log_Day.TabIndex = 12;
            log_Day.Text = "label1";
            // 
            // Days
            // 
            Days.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            Days.Location = new Point(562, 48);
            Days.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Days.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            Days.Name = "Days";
            Days.Size = new Size(61, 31);
            Days.TabIndex = 13;
            Days.Value = new decimal(new int[] { 365, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 48);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 14;
            label1.Text = "Количество дней";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(-1, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1500, 2);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(34, 471);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(402, 329);
            listBox1.TabIndex = 16;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(487, 233);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(805, 567);
            chart1.TabIndex = 17;
            chart1.Text = "chart1";
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(1304, 692);
            button1.Name = "button1";
            button1.Size = new Size(126, 45);
            button1.TabIndex = 18;
            button1.Text = "Стоп";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 201, 245);
            ClientSize = new Size(1439, 830);
            Controls.Add(button1);
            Controls.Add(chart1);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Days);
            Controls.Add(log_Day);
            Controls.Add(save_button);
            Controls.Add(numericUpDown7);
            Controls.Add(numericUpDown8);
            Controls.Add(numericUpDown9);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown6);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(Start);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown9).EndInit();
            ((System.ComponentModel.ISupportInitialize)Days).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown8;
        private NumericUpDown numericUpDown9;
        private Button save_button;
        private Label log_Day;
        private NumericUpDown Days;
        private Label label1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button1;
    }
}
