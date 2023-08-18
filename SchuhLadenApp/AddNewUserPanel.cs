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
    public partial class AddNewUserPanel : Form
    {
        public AddNewUserPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string name = tbxName.Text;
                string vorname = tbxVorname.Text;
                string strasse = tbxStrasse.Text;
                string hausnummer = tbxHausnummer.Text;
                int plz = Convert.ToInt32(tbxPlatz.Text);
                string anstellungszeit = tbxAnstellungszeit.Text;
                double lohngehalt = Convert.ToDouble(tbxLohngehalt.Text);
                string userstatus = tbxUserstatus.Text;
                string account = tbxAccount.Text;
                string password = tbxPassword.Text;

                DatabaseHelper databaseHelper = new DatabaseHelper();

                databaseHelper.OpenConnection();

                User newUser = new User(name, vorname, strasse, hausnummer, plz, anstellungszeit, lohngehalt, userstatus, password, account);

                newUser.setUserId(newUser.CalculateUserId());

                newUser.addNewUser();
                lblStatus.Visible = true;
                lblStatus.BackColor = Color.Green;
                lblStatus.Text = "User succesfully added!";
            } catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.BackColor = Color.Red;
                lblStatus.Text = ex.Message + " Failed to add new User! User Already Exists.";
            }

            



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide(); // Hide the current form
            adminMenu.ShowDialog(); // Show the dialog
            this.Close(); // Close the current form after the dialog is closed

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
