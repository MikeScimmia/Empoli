namespace PuntoVisuale
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            EtichettaPunto = new Label();
            EtichettaX = new Label();
            EtichettaY = new Label();
            SendButton = new Button();
            listBox1 = new ListBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
   
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // EtichettaPunto
            // 
            EtichettaPunto.AutoSize = true;
            EtichettaPunto.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EtichettaPunto.Location = new Point(123, 34);
            EtichettaPunto.Name = "EtichettaPunto";
            EtichettaPunto.Size = new Size(116, 27);
            EtichettaPunto.TabIndex = 2;
            EtichettaPunto.Text = "POLIGONO";
            EtichettaPunto.TextAlign = ContentAlignment.BottomRight;
            EtichettaPunto.Click += label1_Click;
            // 
            // EtichettaX
            // 
            EtichettaX.AutoSize = true;
            EtichettaX.Location = new Point(122, 76);
            EtichettaX.Name = "EtichettaX";
            EtichettaX.Size = new Size(14, 15);
            EtichettaX.TabIndex = 3;
            EtichettaX.Text = "X";
            // 
            // EtichettaY
            // 
            EtichettaY.AutoSize = true;
            EtichettaY.Location = new Point(122, 128);
            EtichettaY.Name = "EtichettaY";
            EtichettaY.Size = new Size(14, 15);
            EtichettaY.TabIndex = 4;
            EtichettaY.Text = "Y";
            // 
            // SendButton
            // 
            SendButton.Location = new Point(336, 243);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(75, 23);
            SendButton.TabIndex = 5;
            SendButton.Text = "Quadrato";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(255, 76);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(533, 139);
            listBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(122, 243);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(123, 300);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 176);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 10;
            label1.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 225);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 11;
            label2.Text = "Altezza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 282);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 12;
            label3.Text = "Profondità";
            // 
            // button1
            // 
            button1.Location = new Point(443, 242);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Rettangolo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(544, 242);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 14;
            button2.Text = "Parallelepipido";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(listBox1);
            Controls.Add(SendButton);
            Controls.Add(EtichettaY);
            Controls.Add(EtichettaX);
            Controls.Add(EtichettaPunto);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label EtichettaPunto;
        private Label EtichettaX;
        private Label EtichettaY;
        private Button SendButton;
        private ListBox listBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}
