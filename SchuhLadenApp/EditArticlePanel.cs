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
    public partial class EditArticlePanel : Form
    {
        public EditArticlePanel()
        {
            InitializeComponent();
            generateArticleView();
        }

        private void generateArticleView()
        {

            // Create columns
            articleGridView.Columns.Add("Article Id", "Article Id\"");
            articleGridView.Columns.Add("Name", "Name");
            articleGridView.Columns.Add("Lieferant", "Lieferant");
            articleGridView.Columns.Add("Preis", "Preis");
            articleGridView.Columns.Add("Menge", "Menge");

            List<Artikel> articleList = Artikel.retrieveArtikelFromDb();

            foreach (Artikel artikel in articleList)
            {
                // Add a row for each user
                articleGridView.Rows.Add(artikel.getArtikelId(), artikel.getName(), artikel.getLieferant(),
                    artikel.getPreis(), artikel.getMenge());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (articleGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = articleGridView.SelectedRows[0];

                List<string> articleInfo = new List<string>();
                foreach (DataGridViewCell cell in dataGridViewRow.Cells)
                {
                    articleInfo.Add(cell.Value.ToString());
                }

                EditArticleInfo editArticleInfo = new EditArticleInfo(articleInfo);
                editArticleInfo.articleInfo = articleInfo;
                editArticleInfo.ShowDialog();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.ShowDialog();
            this.Close();
        }
    }
}
