namespace impiccatoImmagine
{
    public partial class form1 : Form
    {
        string riga, nascosta;
        string[] rigaSPlit;
        int a = 0, t = 0, p = 0;

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
            string p = "";
            for (int i = 0; i < nascosta.Length; i++)
            {
                p += "_ ";
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
            string p = "";
            for (int i = 0; i < nascosta.Length; i++)
            {
                p += "_ ";
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
            string p = "";
            for (int i = 0; i < nascosta.Length; i++)
            {
                p += "_ ";
            }
            parolaf.Text = p;
        }

        private void parolaf_Click(object sender, EventArgs e)
        {

        }
    }
}
