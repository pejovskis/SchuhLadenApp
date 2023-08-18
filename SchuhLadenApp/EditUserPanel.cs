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
    public partial class EditUserPanel : Form
    {
        public EditUserPanel()
        {
            InitializeComponent();

            showUsersList.View = View.Details;

            showUsersList.Columns.Add("User Id", 100);
            showUsersList.Columns.Add("Name", 100);
            showUsersList.Columns.Add("Vorname", 100);
            showUsersList.Columns.Add("Strasse", 100);
            showUsersList.Columns.Add("Hausnummer", 100);
            showUsersList.Columns.Add("Plz", 100);
            showUsersList.Columns.Add("Anstellungszeit", 100);
            showUsersList.Columns.Add("Lohngehalt", 100);
            showUsersList.Columns.Add("Userstatus", 100);
            showUsersList.Columns.Add("Account", 100);

            List<User> userList = User.retrieveUsersFromDb();

            foreach (User user in userList)
            {
                ListViewItem item = new ListViewItem(user.getUserId());
                item.SubItems.Add(user.getUserId());
                item.SubItems.Add(user.getName());
                item.SubItems.Add(user.getVorname());
                item.SubItems.Add(user.getStrasse());
                item.SubItems.Add(user.getHausnummer());
                item.SubItems.Add(user.getPlz().ToString());
                item.SubItems.Add(user.getAnstellungsZeit());
                item.SubItems.Add(user.getLohnGehalt().ToString());
                item.SubItems.Add(user.getUserStatus());
                item.SubItems.Add(user.getAccount());

                showUsersList.Items.Add(item);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.ShowDialog();
            this.Close();
        }
    }
}
