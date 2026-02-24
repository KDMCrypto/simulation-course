namespace lab3
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
            pictureBox1 = new PictureBox();
            rows = new NumericUpDown();
            columns = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            temper = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)columns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)temper).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(32, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1000, 1000);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // rows
            // 
            rows.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            rows.Location = new Point(1187, 73);
            rows.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            rows.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            rows.Name = "rows";
            rows.Size = new Size(180, 31);
            rows.TabIndex = 1;
            rows.Value = new decimal(new int[] { 50, 0, 0, 0 });
            rows.ValueChanged += rows_ValueChanged;
            // 
            // columns
            // 
            columns.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            columns.Location = new Point(1187, 123);
            columns.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            columns.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            columns.Name = "columns";
            columns.Size = new Size(180, 31);
            columns.TabIndex = 2;
            columns.Value = new decimal(new int[] { 50, 0, 0, 0 });
            columns.ValueChanged += columns_ValueChanged;
            columns.Paint += pictureBox1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1053, 73);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 3;
            label1.Text = "Строки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1053, 125);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 4;
            label2.Text = "Столбцы";
            // 
            // button1
            // 
            button1.Location = new Point(1106, 327);
            button1.Name = "button1";
            button1.Size = new Size(194, 82);
            button1.TabIndex = 5;
            button1.Text = "Старт/Стоп";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Нет", "Север", "Юг", "Запад", "Восток" });
            comboBox1.Location = new Point(1185, 227);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += Wind;
            // 
            // temper
            // 
            temper.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            temper.Location = new Point(1187, 174);
            temper.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            temper.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            temper.Name = "temper";
            temper.Size = new Size(180, 31);
            temper.TabIndex = 7;
            temper.ValueChanged += temperature;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1053, 176);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 8;
            label3.Text = "Температура";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1053, 230);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 9;
            label4.Text = "Ветер";
            // 
            // button2
            // 
            button2.Location = new Point(1106, 450);
            button2.Name = "button2";
            button2.Size = new Size(194, 82);
            button2.TabIndex = 10;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 1242);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(temper);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(columns);
            Controls.Add(rows);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rows).EndInit();
            ((System.ComponentModel.ISupportInitialize)columns).EndInit();
            ((System.ComponentModel.ISupportInitialize)temper).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private NumericUpDown rows;
        private NumericUpDown columns;
        private Label label1;
        private Label label2;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private NumericUpDown temper;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}
