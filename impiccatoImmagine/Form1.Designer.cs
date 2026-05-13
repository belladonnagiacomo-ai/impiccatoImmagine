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
            animali = new Button();
            paesi = new Button();
            tecnologia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(289, 39);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(530, 40);
            label1.TabIndex = 0;
            label1.Text = "Che categoria vuoi scegliere?";
            // 
            // animali
            // 
            animali.BackgroundImageLayout = ImageLayout.Center;
            animali.ForeColor = Color.Black;
            animali.ImageAlign = ContentAlignment.TopLeft;
            animali.Location = new Point(163, 155);
            animali.Name = "animali";
            animali.Size = new Size(213, 46);
            animali.TabIndex = 1;
            animali.Text = "categoria animali";
            animali.UseVisualStyleBackColor = true;
            animali.Click += button1_Click;
            // 
            // paesi
            // 
            paesi.Location = new Point(463, 155);
            paesi.Name = "paesi";
            paesi.Size = new Size(213, 46);
            paesi.TabIndex = 2;
            paesi.Text = "categoria paesi";
            paesi.UseVisualStyleBackColor = true;
            paesi.Click += button2_Click;
            // 
            // tecnologia
            // 
            tecnologia.Location = new Point(745, 155);
            tecnologia.Name = "tecnologia";
            tecnologia.Size = new Size(213, 46);
            tecnologia.TabIndex = 3;
            tecnologia.Text = "categoria tecnologia";
            tecnologia.UseVisualStyleBackColor = true;
            tecnologia.Click += button3_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 881);
            Controls.Add(tecnologia);
            Controls.Add(paesi);
            Controls.Add(animali);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "form1";
            Text = "tecno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button animali;
        private Button paesi;
        private Button tecnologia;
    }
}
