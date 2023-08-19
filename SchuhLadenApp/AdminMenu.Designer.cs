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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            lblLogedInUser = new Label();
            SuspendLayout();
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.Location = new Point(152, 112);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(129, 23);
            btnAddNewUser.TabIndex = 0;
            btnAddNewUser.Text = "add new user";
            btnAddNewUser.UseVisualStyleBackColor = true;
            btnAddNewUser.Click += button1_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(152, 228);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // button1
            // 
            button1.Location = new Point(152, 141);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 2;
            button1.Text = "show users";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(152, 170);
            button2.Name = "button2";
            button2.Size = new Size(129, 23);
            button2.TabIndex = 3;
            button2.Text = "add new article";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(152, 199);
            button3.Name = "button3";
            button3.Size = new Size(129, 23);
            button3.TabIndex = 4;
            button3.Text = "show articles";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 38);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 5;
            label1.Text = "Logged in as:";
            // 
            // lblLogedInUser
            // 
            lblLogedInUser.AutoSize = true;
            lblLogedInUser.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogedInUser.Location = new Point(177, 53);
            lblLogedInUser.Name = "lblLogedInUser";
            lblLogedInUser.Size = new Size(83, 46);
            lblLogedInUser.TabIndex = 6;
            lblLogedInUser.Text = "user";
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 381);
            Controls.Add(lblLogedInUser);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnLogout);
            Controls.Add(btnAddNewUser);
            Name = "AdminMenu";
            Text = "AdminMenu";
            Load += AdminMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNewUser;
        private Button btnLogout;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label lblLogedInUser;
    }
}