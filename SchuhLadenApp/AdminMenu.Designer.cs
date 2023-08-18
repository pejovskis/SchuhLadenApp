namespace SchuhLadenApp
{
    partial class AdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddNewUser = new Button();
            btnLogout = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.Location = new Point(143, 63);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(129, 23);
            btnAddNewUser.TabIndex = 0;
            btnAddNewUser.Text = "add new user";
            btnAddNewUser.UseVisualStyleBackColor = true;
            btnAddNewUser.Click += button1_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(143, 167);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // button1
            // 
            button1.Location = new Point(143, 102);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 2;
            button1.Text = "edit user";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 245);
            Controls.Add(button1);
            Controls.Add(btnLogout);
            Controls.Add(btnAddNewUser);
            Name = "AdminMenu";
            Text = "AdminMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddNewUser;
        private Button btnLogout;
        private Button button1;
    }
}