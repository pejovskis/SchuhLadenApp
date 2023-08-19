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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewUserPanel addNewUserPanel = new AddNewUserPanel();
            this.Hide();
            addNewUserPanel.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPanel loginPanel = new LoginPanel();
            this.Hide();
            loginPanel.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EditUserPanel editUserPanel = new EditUserPanel();
            this.Hide();
            editUserPanel.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNewArticlePanel addNewArticlePanel = new addNewArticlePanel();
            this.Hide();
            addNewArticlePanel.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditArticlePanel editArticlePanel = new EditArticlePanel();
            this.Hide();
            editArticlePanel.ShowDialog();
            this.Close();
        }
    }
}
