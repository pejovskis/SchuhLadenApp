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
    public partial class addNewArticlePanel : Form
    {
        public addNewArticlePanel()
        {
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbxName.Text;
                string lieferant = tbxLieferant.Text;
                double preis = Convert.ToDouble(tbxPreis.Text);
                int menge = Convert.ToInt32(tbxMenge.Text);

                DatabaseHelper databaseHelper = new DatabaseHelper();

                databaseHelper.OpenConnection();

                Artikel artikel = new Artikel(name, lieferant, preis, menge);

                artikel.setArtikelId(artikel.CalculateArtikelId());

                artikel.addNewArtikel();
                lblStatus.Visible = true;
                lblStatus.BackColor = Color.Green;
                lblStatus.Text = "Article succesfully added!";
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.BackColor = Color.Red;
                lblStatus.Text = ex.Message + " Failed to add new Article! Article with this ID Already Exists.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
