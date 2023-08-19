using Microsoft.VisualBasic.ApplicationServices;

namespace SchuhLadenApp
{
    public partial class LoginPanel : Form
    {

        public static User LoggedInUser { get; private set; }

        public LoginPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = inUsername.Text;
            string password = inPassword.Text;

            User user = new User(username, password);
            bool logInApproved = user.checkUserCredentials(username, password);

            if (!logInApproved)
            {
                lblStatus.Text = "Wrong Username or Password";
                lblStatus.Visible = true;
            }
            else
            {
                LoggedInUser = user.getFullUserCredentials(username, password);
                AdminMenu adminMenu = new AdminMenu();
                this.Hide();
                adminMenu.ShowDialog();
                this.Close();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}