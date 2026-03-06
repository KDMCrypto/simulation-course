namespace lab5
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(225, 229);
            button1.Name = "button1";
            button1.Size = new Size(150, 65);
            button1.TabIndex = 0;
            button1.Text = "ОТВЕТ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(55, 150);
            label1.Name = "label1";
            label1.Size = new Size(490, 36);
            label1.TabIndex = 1;
            label1.Text = "Вставать на первую пару? ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Courier New", 28F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(222, 351);
            label2.Name = "label2";
            label2.Size = new Size(156, 73);
            label2.TabIndex = 2;
            label2.Text = "***";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(765, 150);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(450, 56);
            textBox1.TabIndex = 3;
            textBox1.Text = "Вставать на пару?";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(925, 229);
            button2.Name = "button2";
            button2.Size = new Size(150, 65);
            button2.TabIndex = 4;
            button2.Text = "СПРОСИТЬ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Courier New", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(625, 351);
            label3.Name = "label3";
            label3.Size = new Size(750, 46);
            label3.TabIndex = 5;
            label3.Text = "***";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(1236, 588);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1378, 644);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private Label label3;
        private Button button3;
    }
}
