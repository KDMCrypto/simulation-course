namespace lab10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Start_Button = new Button();
            Close_button = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            listBox1 = new ListBox();
            lambda_form = new NumericUpDown();
            mu_form = new NumericUpDown();
            simulation_time_form = new NumericUpDown();
            devices_form = new NumericUpDown();
            max_time_form = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lambda_form).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mu_form).BeginInit();
            ((System.ComponentModel.ISupportInitialize)simulation_time_form).BeginInit();
            ((System.ComponentModel.ISupportInitialize)devices_form).BeginInit();
            ((System.ComponentModel.ISupportInitialize)max_time_form).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // Start_Button
            // 
            Start_Button.BackColor = Color.Green;
            Start_Button.FlatStyle = FlatStyle.Popup;
            Start_Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Start_Button.ForeColor = SystemColors.Window;
            Start_Button.Location = new Point(1390, 249);
            Start_Button.Name = "Start_Button";
            Start_Button.Size = new Size(90, 45);
            Start_Button.TabIndex = 0;
            Start_Button.Text = "Старт";
            Start_Button.UseVisualStyleBackColor = false;
            Start_Button.Click += Start_Button_Click;
            // 
            // Close_button
            // 
            Close_button.BackColor = Color.Red;
            Close_button.FlatStyle = FlatStyle.Popup;
            Close_button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Close_button.ForeColor = SystemColors.Window;
            Close_button.Location = new Point(1435, 21);
            Close_button.Name = "Close_button";
            Close_button.Size = new Size(45, 45);
            Close_button.TabIndex = 1;
            Close_button.Text = "X";
            Close_button.UseVisualStyleBackColor = false;
            Close_button.Click += Close_button_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(12, 310);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(699, 525);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(717, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(458, 229);
            listBox1.TabIndex = 3;
            // 
            // lambda_form
            // 
            lambda_form.DecimalPlaces = 1;
            lambda_form.Location = new Point(275, 21);
            lambda_form.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            lambda_form.Name = "lambda_form";
            lambda_form.Size = new Size(90, 31);
            lambda_form.TabIndex = 4;
            lambda_form.Value = new decimal(new int[] { 22, 0, 0, 0 });
            // 
            // mu_form
            // 
            mu_form.DecimalPlaces = 1;
            mu_form.Location = new Point(275, 83);
            mu_form.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            mu_form.Name = "mu_form";
            mu_form.Size = new Size(90, 31);
            mu_form.TabIndex = 5;
            mu_form.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // simulation_time_form
            // 
            simulation_time_form.Location = new Point(275, 263);
            simulation_time_form.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            simulation_time_form.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            simulation_time_form.Name = "simulation_time_form";
            simulation_time_form.Size = new Size(90, 31);
            simulation_time_form.TabIndex = 6;
            simulation_time_form.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // devices_form
            // 
            devices_form.Location = new Point(275, 139);
            devices_form.Name = "devices_form";
            devices_form.Size = new Size(90, 31);
            devices_form.TabIndex = 8;
            devices_form.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // max_time_form
            // 
            max_time_form.Location = new Point(275, 201);
            max_time_form.Name = "max_time_form";
            max_time_form.Size = new Size(90, 31);
            max_time_form.TabIndex = 7;
            max_time_form.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(38, 23);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 9;
            label1.Text = "Лямбда:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Location = new Point(38, 85);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 10;
            label2.Text = "Мю:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Location = new Point(38, 265);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 11;
            label3.Text = "Кол-во заявок:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.Location = new Point(38, 139);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 12;
            label4.Text = "Кол-во приборов:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Info;
            label5.Location = new Point(38, 201);
            label5.Name = "label5";
            label5.Size = new Size(202, 25);
            label5.TabIndex = 13;
            label5.Text = "Макс время ожидания:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Info;
            pictureBox1.Location = new Point(12, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1480, 302);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(717, 310);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(775, 537);
            chart2.TabIndex = 15;
            chart2.Text = "chart2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 847);
            Controls.Add(chart2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(devices_form);
            Controls.Add(max_time_form);
            Controls.Add(simulation_time_form);
            Controls.Add(mu_form);
            Controls.Add(lambda_form);
            Controls.Add(listBox1);
            Controls.Add(chart1);
            Controls.Add(Close_button);
            Controls.Add(Start_Button);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lambda_form).EndInit();
            ((System.ComponentModel.ISupportInitialize)mu_form).EndInit();
            ((System.ComponentModel.ISupportInitialize)simulation_time_form).EndInit();
            ((System.ComponentModel.ISupportInitialize)devices_form).EndInit();
            ((System.ComponentModel.ISupportInitialize)max_time_form).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Start_Button;
        private Button Close_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ListBox listBox1;
        private NumericUpDown lambda_form;
        private NumericUpDown mu_form;
        private NumericUpDown simulation_time_form;
        private NumericUpDown devices_form;
        private NumericUpDown max_time_form;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}
