namespace lab9
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
            lambda_form = new NumericUpDown();
            mu_form = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            N_form = new NumericUpDown();
            button1 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)lambda_form).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mu_form).BeginInit();
            ((System.ComponentModel.ISupportInitialize)N_form).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // start_button
            // 
            start_button.BackColor = Color.Green;
            start_button.FlatStyle = FlatStyle.Popup;
            start_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            start_button.ForeColor = SystemColors.Window;
            start_button.Location = new Point(923, 729);
            start_button.Name = "start_button";
            start_button.Size = new Size(112, 46);
            start_button.TabIndex = 0;
            start_button.Text = "Старт";
            start_button.UseVisualStyleBackColor = false;
            start_button.Click += start_button_Click;
            // 
            // lambda_form
            // 
            lambda_form.DecimalPlaces = 1;
            lambda_form.Location = new Point(357, 36);
            lambda_form.Name = "lambda_form";
            lambda_form.Size = new Size(86, 31);
            lambda_form.TabIndex = 1;
            lambda_form.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // mu_form
            // 
            mu_form.DecimalPlaces = 1;
            mu_form.Location = new Point(357, 92);
            mu_form.Name = "mu_form";
            mu_form.Size = new Size(86, 31);
            mu_form.TabIndex = 2;
            mu_form.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 38);
            label1.Name = "label1";
            label1.Size = new Size(295, 25);
            label1.TabIndex = 3;
            label1.Text = "Интенсивность входящего потока:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 94);
            label3.Name = "label3";
            label3.Size = new Size(261, 25);
            label3.TabIndex = 5;
            label3.Text = "Интенсивность обслуживания:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 151);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 7;
            label2.Text = "Количество заявок:";
            // 
            // N_form
            // 
            N_form.Location = new Point(357, 149);
            N_form.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            N_form.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            N_form.Name = "N_form";
            N_form.Size = new Size(86, 31);
            N_form.TabIndex = 6;
            N_form.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(995, 23);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
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
            chart1.Location = new Point(23, 210);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(623, 565);
            chart1.TabIndex = 9;
            chart1.Text = "chart1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(671, 210);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(364, 179);
            listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 798);
            Controls.Add(listBox1);
            Controls.Add(chart1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(N_form);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(mu_form);
            Controls.Add(lambda_form);
            Controls.Add(start_button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)lambda_form).EndInit();
            ((System.ComponentModel.ISupportInitialize)mu_form).EndInit();
            ((System.ComponentModel.ISupportInitialize)N_form).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start_button;
        private NumericUpDown lambda_form;
        private NumericUpDown mu_form;
        private Label label1;
        private Label label3;
        private Label label2;
        private NumericUpDown N_form;
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ListBox listBox1;
    }
}
