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
            generateUserGridView();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.ShowDialog();
            this.Close();
        }

        // Generate the list
        private void generateUserGridView()
        {

            // Create columns
            showUsersGrid.Columns.Add("UserId", "User Id");
            showUsersGrid.Columns.Add("Name", "Name");
            showUsersGrid.Columns.Add("Vorname", "Vorname");
            showUsersGrid.Columns.Add("Strasse", "Strasse");
            showUsersGrid.Columns.Add("Hausnummer", "Hausnummer");
            showUsersGrid.Columns.Add("Plz", "Plz");
            showUsersGrid.Columns.Add("Anstellungszeit", "Anstellungszeit");
            showUsersGrid.Columns.Add("Lohngehalt", "Lohngehalt");
            showUsersGrid.Columns.Add("Userstatus", "Userstatus");
            showUsersGrid.Columns.Add("Account", "Account");

            List<User> userList = User.retrieveUsersFromDb();

            foreach (User user in userList)
            {
                // Add a row for each user
                showUsersGrid.Rows.Add(user.getUserId(), user.getName(), user.getVorname(), user.getStrasse(),
                    user.getHausnummer(), user.getPlz(), user.getAnstellungsZeit(),
                    user.getLohnGehalt(), user.getUserStatus(), user.getAccount());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (showUsersGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = showUsersGrid.SelectedRows[0];

                List<string> userInfo = new List<string>();
                foreach (DataGridViewCell cell in dataGridViewRow.Cells)
                {
                    userInfo.Add(cell.Value.ToString());
                }

                EditUserInfo editUsersListCellForm = new EditUserInfo(userInfo);
                editUsersListCellForm.userInfo = userInfo;
                editUsersListCellForm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
