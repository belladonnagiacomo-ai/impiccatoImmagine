namespace impiccatoImmagine
{
    public partial class form1 : Form
    {
        string riga, nascosta, p;
        string[] rigaSPlit;

        private void menu()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
        }

        private void Difficoltà()
        {
            label2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }

        private void Elimina()
        {
            label2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void Crea()
        {
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        public form1()
        {
            InitializeComponent();
            label2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            parolaf.Visible = false;
            lettera.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Random r = new Random();
            List<string> animali = new List<string>(File.ReadLines("animali.csv"));
            animali.RemoveAt(0);

            int num = r.Next(1, 10);
            riga = animali[num];

            menu();
            Difficoltà();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            List<string> paesi = new List<string>(File.ReadLines("animali.csv"));
            paesi.RemoveAt(0);

            int num = r.Next(1, 10);
            riga = paesi[num];

            menu();
            Difficoltà();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            List<string> tecno = new List<string>(File.ReadLines("animali.csv"));
            tecno.RemoveAt(0);

            int num = r.Next(1, 10);
            riga = tecno[num];

            menu();
            Difficoltà();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Elimina();
            Crea();
            parolaf.Visible = true;
            rigaSPlit = riga.Split(",");
            nascosta = rigaSPlit[0];
            lettera.Visible = true;
            for (int i = 0; i < nascosta.Length; i++)
            {
                p += "-";
            }
            parolaf.Text = p;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Elimina();
            Crea();
            rigaSPlit = riga.Split(",");
            nascosta = rigaSPlit[1];
            parolaf.Visible = true;
            lettera.Visible = true;
            for (int i = 0; i < nascosta.Length; i++)
            {
                p += "-";
            }
            parolaf.Text = p;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Elimina();
            Crea();
            rigaSPlit = riga.Split(",");
            nascosta = rigaSPlit[2];
            parolaf.Visible = true;
            lettera.Visible = true;

            for (int i = 0; i < nascosta.Length; i++)
            {
                p += "-";
            }
            parolaf.Text = p;
            
        }

        private void parolaf_Click(object sender, EventArgs e)
        {

        }

        private void lettera_Click(object sender, EventArgs e)
        {
            char[] parolac = nascosta.ToCharArray();
            char[] trattini = p.ToCharArray();

            bool contiene = nascosta.Contains(textBox1.Text[0]);
            if (contiene == true)
            {
                for (int i = 0; i < nascosta.Length; i++)
                {
                    if (parolac[i] == textBox1.Text[0])
                    {
                        trattini[i] = textBox1.Text[0];

                    }
                }
            }

            parolaf.Text = new string(trattini);
        }
    }
}
