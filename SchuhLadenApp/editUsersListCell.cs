using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchuhLadenApp
{
    public partial class editUsersListCell : Form
    {

        public string EditedValue
        {
            get { return tbxInEdit.Text; }
            set { tbxInEdit.Text = value; }
        }

        public editUsersListCell()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
