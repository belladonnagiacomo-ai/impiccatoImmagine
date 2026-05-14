namespace impiccatoImmagine
{
    partial class form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            parola = new Label();
            parolaf = new Label();
            lettera = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(761, 42);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(256, 50);
            label1.TabIndex = 0;
            label1.Text = " categoria ";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Stencil", 18F, FontStyle.Italic);
            button1.ForeColor = Color.Black;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(223, 193);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(411, 56);
            button1.TabIndex = 1;
            button1.Text = "categoria animali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 18F, FontStyle.Italic);
            button2.Location = new Point(644, 191);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(350, 56);
            button2.TabIndex = 2;
            button2.Text = "categoria paesi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Stencil", 18F, FontStyle.Italic);
            button3.Location = new Point(1004, 189);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(411, 56);
            button3.TabIndex = 3;
            button3.Text = "categoria tecnologia";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 24F, FontStyle.Italic);
            label2.Location = new Point(624, 42);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(437, 50);
            label2.TabIndex = 4;
            label2.Text = "Scegli la difficoltà";
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.ForeColor = Color.Black;
            button4.ImageAlign = ContentAlignment.TopLeft;
            button4.Location = new Point(223, 191);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(411, 56);
            button4.TabIndex = 5;
            button4.Text = "facile ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.ForeColor = Color.Black;
            button5.ImageAlign = ContentAlignment.TopLeft;
            button5.Location = new Point(644, 193);
            button5.Margin = new Padding(5, 4, 5, 4);
            button5.Name = "button5";
            button5.Size = new Size(350, 56);
            button5.TabIndex = 6;
            button5.Text = "medio";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.ForeColor = Color.Black;
            button6.ImageAlign = ContentAlignment.TopLeft;
            button6.Location = new Point(1004, 189);
            button6.Margin = new Padding(5, 4, 5, 4);
            button6.Name = "button6";
            button6.Size = new Size(411, 56);
            button6.TabIndex = 7;
            button6.Text = "difficile";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 594);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 51);
            textBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BT", 24F, FontStyle.Italic | FontStyle.Underline);
            label3.Location = new Point(223, 517);
            label3.Name = "label3";
            label3.Size = new Size(142, 48);
            label3.TabIndex = 9;
            label3.Text = "Lettera";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(896, 594);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(472, 51);
            textBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Swis721 BT", 24F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(896, 529);
            label4.Name = "label4";
            label4.Size = new Size(132, 48);
            label4.TabIndex = 11;
            label4.Text = "Parola";
            // 
            // parola
            // 
            parola.AutoSize = true;
            parola.Location = new Point(775, 336);
            parola.Name = "parola";
            parola.Size = new Size(0, 44);
            parola.TabIndex = 12;
            // 
            // parolaf
            // 
            parolaf.AutoSize = true;
            parolaf.Font = new Font("Showcard Gothic", 24F, FontStyle.Italic);
            parolaf.Location = new Point(732, 381);
            parolaf.Name = "parolaf";
            parolaf.Size = new Size(158, 50);
            parolaf.TabIndex = 13;
            parolaf.Text = "label5";
            parolaf.Click += parolaf_Click;
            // 
            // lettera
            // 
            lettera.Location = new Point(223, 375);
            lettera.Name = "lettera";
            lettera.Size = new Size(381, 73);
            lettera.TabIndex = 14;
            lettera.Text = "inserisci lettera";
            lettera.UseVisualStyleBackColor = true;
            lettera.Click += lettera_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(23F, 44F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1844, 988);
            Controls.Add(lettera);
            Controls.Add(parolaf);
            Controls.Add(parola);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Stencil", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 7, 8, 7);
            Name = "form1";
            Text = "tecno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label parola;
        private Label parolaf;
        private Button lettera;
    }
}
