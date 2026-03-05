namespace lab4
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
            button1 = new Button();
            button2 = new Button();
            SampleSize = new NumericUpDown();
            listBox1 = new ListBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)SampleSize).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(598, 56);
            button1.Name = "button1";
            button1.Size = new Size(177, 54);
            button1.TabIndex = 0;
            button1.Text = "Сгенерировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(598, 147);
            button2.Name = "button2";
            button2.Size = new Size(177, 54);
            button2.TabIndex = 1;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SampleSize
            // 
            SampleSize.Location = new Point(228, 56);
            SampleSize.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            SampleSize.Name = "SampleSize";
            SampleSize.Size = new Size(180, 31);
            SampleSize.TabIndex = 2;
            SampleSize.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(46, 123);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(486, 179);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 58);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 4;
            label1.Text = "Размер выборки";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(822, 336);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(SampleSize);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)SampleSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private NumericUpDown SampleSize;
        private ListBox listBox1;
        private Label label1;
    }
}
