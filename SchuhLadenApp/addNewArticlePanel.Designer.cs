namespace SchuhLadenApp
{
    partial class addNewArticlePanel
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
            lblStatus = new Label();
            btnBack = new Button();
            btnAddNewUser = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            tbxLieferant = new TextBox();
            label2 = new Label();
            tbxName = new TextBox();
            tbxPreis = new TextBox();
            tbxMenge = new TextBox();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(382, 301);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 36;
            lblStatus.Text = "status";
            lblStatus.Visible = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(280, 263);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 23);
            btnBack.TabIndex = 35;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.Location = new Point(401, 263);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(128, 23);
            btnAddNewUser.TabIndex = 34;
            btnAddNewUser.Text = "add new article";
            btnAddNewUser.UseVisualStyleBackColor = true;
            btnAddNewUser.Click += btnAddNewUser_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 200);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 31;
            label4.Text = "menge";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 152);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 29;
            label5.Text = "preis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 107);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 27;
            label3.Text = "Lieferant";
            label3.Click += label3_Click;
            // 
            // tbxLieferant
            // 
            tbxLieferant.Location = new Point(280, 125);
            tbxLieferant.Name = "tbxLieferant";
            tbxLieferant.Size = new Size(249, 23);
            tbxLieferant.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 59);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 25;
            label2.Text = "Name";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(280, 77);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(249, 23);
            tbxName.TabIndex = 24;
            // 
            // tbxPreis
            // 
            tbxPreis.Location = new Point(280, 174);
            tbxPreis.Name = "tbxPreis";
            tbxPreis.Size = new Size(249, 23);
            tbxPreis.TabIndex = 37;
            // 
            // tbxMenge
            // 
            tbxMenge.Location = new Point(280, 218);
            tbxMenge.Name = "tbxMenge";
            tbxMenge.Size = new Size(249, 23);
            tbxMenge.TabIndex = 38;
            // 
            // addNewArticlePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 369);
            Controls.Add(tbxMenge);
            Controls.Add(tbxPreis);
            Controls.Add(lblStatus);
            Controls.Add(btnBack);
            Controls.Add(btnAddNewUser);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(tbxLieferant);
            Controls.Add(label2);
            Controls.Add(tbxName);
            Name = "addNewArticlePanel";
            Text = "addNewArticlePanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button btnBack;
        private Button btnAddNewUser;
        private Label label7;
        private TextBox tbxPlatz;
        private Label label4;
        private TextBox tbxHausnummer;
        private Label label5;
        private TextBox tbxStrasse;
        private Label label3;
        private TextBox tbxLieferant;
        private Label label2;
        private TextBox tbxName;
        private TextBox tbxPreis;
        private TextBox tbxMenge;
    }
}