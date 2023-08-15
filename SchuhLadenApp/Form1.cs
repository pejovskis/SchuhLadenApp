using Microsoft.VisualBasic.ApplicationServices;

namespace SchuhLadenApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = "test";
            string lieferant ="test";
            double preis = 5043;
            int menge = 5;

            Artikel artikel = new Artikel(name, lieferant, preis, menge);
            artikel.setArtikelId(artikel.CalculateArtikelId());

            artikel.addNewArtikel();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}