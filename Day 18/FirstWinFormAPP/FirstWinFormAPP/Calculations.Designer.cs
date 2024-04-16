namespace FirstWinFormAPP
{
    partial class Calculations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(318, 44);
            label1.Name = "label1";
            label1.Size = new Size(192, 57);
            label1.TabIndex = 0;
            label1.Text = "Calculate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 146);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 1;
            label2.Text = "First Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 215);
            label3.Name = "label3";
            label3.Size = new Size(163, 30);
            label3.TabIndex = 2;
            label3.Text = "Second Number";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Add", "Subtract", "Multiply", "Divide" });
            comboBox1.Location = new Point(319, 271);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 38);
            comboBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 35);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(317, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 35);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 274);
            label4.Name = "label4";
            label4.Size = new Size(73, 30);
            label4.TabIndex = 7;
            label4.Text = "Action";
            // 
            // button1
            // 
            button1.Location = new Point(257, 348);
            button1.Name = "button1";
            button1.Size = new Size(205, 40);
            button1.TabIndex = 8;
            button1.Text = "Result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Calculations
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calculations";
            Text = "Calculations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
    }
}