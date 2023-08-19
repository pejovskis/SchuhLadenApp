using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchuhLadenApp
{
    public partial class EditArticleInfo : Form
    {

        public List<string> articleInfo { get; set; } = new List<string>();

        public EditArticleInfo(List<string> articleInfo)
        {
            this.articleInfo = articleInfo;
            InitializeComponent();
            generateArticleInfo();
        }

        private void EditArticleInfo_Load(object sender, EventArgs e)
        {
            
        }

        public void generateArticleInfo()
        {
            // Create columns
            articleShowGrid.Columns.Add("Articleid", "Articleid");
            articleShowGrid.Columns.Add("Name", "Name");
            articleShowGrid.Columns.Add("Lieferant", "Lieferant");
            articleShowGrid.Columns.Add("Preis", "Preis");
            articleShowGrid.Columns.Add("Menge", "Menge");

            DataGridViewRow row = new DataGridViewRow();

            row.CreateCells(articleShowGrid, articleInfo[0], articleInfo[1], articleInfo[2], articleInfo[3], 
                articleInfo[4]);

            articleShowGrid.Rows.Add(row);

            row.Cells["Articleid"].ReadOnly = true;
            row.Cells["Articleid"].Style.BackColor = Color.Gray;
        }

        private Artikel getArticleInfo(DataGridViewRow row)
        {
            string artikelid = row.Cells[0].Value.ToString();
            string name = row.Cells[1].Value.ToString();
            string lieferant = row.Cells[2].Value.ToString();
            double preis = Convert.ToDouble(row.Cells[3].Value.ToString());
            int menge = Convert.ToInt32(row.Cells[4].Value.ToString());

            Artikel artikel = new Artikel(artikelid, name, lieferant, preis, menge);

            return artikel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditArticlePanel editArticlePanel = new EditArticlePanel();
            this.Hide();
            editArticlePanel.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (articleShowGrid.Rows.Count > 0)
            {

                DataGridViewRow row = articleShowGrid.Rows[0];

                Artikel article = getArticleInfo(row);

                article.updateArticle();

                MessageBox.Show("Article " + article.getArtikelId() + " updated successfully!");

            }

            EditArticlePanel editArticlePanel = new EditArticlePanel();
            this.Hide();
            editArticlePanel.ShowDialog();
            this.Close();
        }

        private void articleShowGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
