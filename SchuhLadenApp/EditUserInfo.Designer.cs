namespace SchuhLadenApp
{
    partial class EditUserInfo
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
            btnSave = new Button();
            gridCellEdit = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)gridCellEdit).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(417, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "update user";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // gridCellEdit
            // 
            gridCellEdit.AllowUserToAddRows = false;
            gridCellEdit.AllowUserToDeleteRows = false;
            gridCellEdit.AllowUserToOrderColumns = true;
            gridCellEdit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCellEdit.Location = new Point(68, 174);
            gridCellEdit.Name = "gridCellEdit";
            gridCellEdit.RowTemplate.Height = 25;
            gridCellEdit.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridCellEdit.Size = new Size(653, 70);
            gridCellEdit.TabIndex = 2;
            gridCellEdit.CellContentClick += gridCellEdit_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(303, 250);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // EditUserInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(gridCellEdit);
            Controls.Add(btnSave);
            Name = "EditUserInfo";
            Text = "editUsersListCell";
            ((System.ComponentModel.ISupportInitialize)gridCellEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSave;
        private DataGridView gridCellEdit;
        private Button btnBack;
    }
}