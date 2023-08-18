namespace SchuhLadenApp
{
    partial class LoginPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inPassword = new TextBox();
            btnLogin = new Button();
            inUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // inPassword
            // 
            inPassword.Location = new Point(144, 124);
            inPassword.Name = "inPassword";
            inPassword.Size = new Size(246, 23);
            inPassword.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(224, 173);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // inUsername
            // 
            inUsername.Location = new Point(144, 60);
            inUsername.Name = "inUsername";
            inUsername.Size = new Size(246, 23);
            inUsername.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 42);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 106);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(245, 208);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "label3";
            lblStatus.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 257);
            Controls.Add(lblStatus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inUsername);
            Controls.Add(btnLogin);
            Controls.Add(inPassword);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inPassword;
        private Button btnLogin;
        private TextBox inUsername;
        private Label label1;
        private Label label2;
        private Label lblStatus;
    }
}