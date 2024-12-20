namespace araba_kiralama_test
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 38);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Bilgi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 87);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 129);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 170);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 3;
            label4.Text = "Tc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 216);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 4;
            label5.Text = "Tel No:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(80, 170);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(80, 209);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 259);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 562);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Araba Kiralama Sistemi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private GroupBox groupBox1;
    }
}
