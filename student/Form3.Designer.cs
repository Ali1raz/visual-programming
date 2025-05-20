namespace student
{
    partial class Form3
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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 0;
            label1.Text = "for teacher";
            // 
            // button1
            // 
            button1.Location = new Point(713, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 65);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 106);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 3;
            label3.Text = "address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 151);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 4;
            label4.Text = "Contact number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 192);
            label5.Name = "label5";
            label5.Size = new Size(41, 19);
            label5.TabIndex = 5;
            label5.Text = "email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 250);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 6;
            label6.Text = "course";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(466, 26);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(466, 26);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(466, 26);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(154, 148);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(466, 26);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(154, 106);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(466, 26);
            textBox5.TabIndex = 11;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}