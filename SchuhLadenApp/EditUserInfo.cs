using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchuhLadenApp
{
    public partial class EditUserInfo : Form
    {

        public List<string> userInfo { get; set; } = new List<string>();

        public EditUserInfo(List<string> userInfo)
        {
            this.userInfo = userInfo;
            InitializeComponent();
            generateUserGridView();
        }

        public void generateUserGridView()
        {
            // Create columns
            gridCellEdit.Columns.Add("Userid", "Userid");
            gridCellEdit.Columns.Add("Name", "Name");
            gridCellEdit.Columns.Add("Vorname", "Vorname");
            gridCellEdit.Columns.Add("Strasse", "Strasse");
            gridCellEdit.Columns.Add("Hausnummer", "Hausnummer");
            gridCellEdit.Columns.Add("Plz", "Plz");
            gridCellEdit.Columns.Add("Anstellungszeit", "Anstellungszeit");
            gridCellEdit.Columns.Add("Lohngehalt", "Lohngehalt");
            gridCellEdit.Columns.Add("Userstatus", "Userstatus");
            gridCellEdit.Columns.Add("Account", "Account");

            DataGridViewRow row = new DataGridViewRow();

            row.CreateCells(gridCellEdit, userInfo[0], userInfo[1], userInfo[2], userInfo[3], userInfo[4],
                userInfo[5], userInfo[6], userInfo[7], userInfo[8], userInfo[9]);

            gridCellEdit.Rows.Add(row);

            row.Cells["Userid"].ReadOnly = true;
            row.Cells["Userid"].Style.BackColor = Color.Gray;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (gridCellEdit.Rows.Count > 0)
            {

                DataGridViewRow row = gridCellEdit.Rows[0];

                User user = getUserInfo(row);

                user.updateUser();

                MessageBox.Show("User " + user.getVorname() + " updated successfully!");

            }

            EditUserPanel editUserPanel = new EditUserPanel();
            this.Hide();
            editUserPanel.ShowDialog();
            this.Close();
        }

        private User getUserInfo(DataGridViewRow row)
        {
            string userid = row.Cells[0].Value.ToString();
            string name = row.Cells[1].Value.ToString();
            string vorname = row.Cells[2].Value.ToString();
            string strasse = row.Cells[3].Value.ToString();
            string hausnummer = row.Cells[4].Value.ToString();
            int plz = Convert.ToInt32(row.Cells[5].Value.ToString());
            string anstellungszeit = row.Cells[6].Value.ToString();
            double lohngehalt = Convert.ToDouble(row.Cells[7].Value.ToString());
            string userstatus = row.Cells[8].Value.ToString();
            string account = row.Cells[9].Value.ToString();

            User user = new User(userid, name, vorname, strasse, hausnummer, plz,
                anstellungszeit, lohngehalt, userstatus, account);

            return user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EditUserPanel editUserPanel = new EditUserPanel();
            this.Hide();
            editUserPanel.ShowDialog();
            this.Close();
        }

        private void gridCellEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
