namespace impiccatoImmagine
{
    public partial class form1 : Form
    {
        string riga;

        private void menu()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
        }
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            List<string> animali = new List<string>(File.ReadLines("animali.csv"));
            animali.RemoveAt(0);

            int num = r.Next(1, 10);
            riga = animali[num];

            menu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            List<string> paesi = new List<string>(File.ReadLines("animali.csv"));
            paesi.RemoveAt(0);

            int num = r.Next(1, 10);
            riga = paesi[num];

            menu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            List<string> tecno = new List<string>(File.ReadLines("animali.csv"));
            tecno.RemoveAt(0);

            int num = r.Next(1, 10);
            riga = tecno[num];

            menu();
        }
    }
}
