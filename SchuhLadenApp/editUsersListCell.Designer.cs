﻿namespace SchuhLadenApp
{
    partial class editUsersListCell
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
            tbxInEdit = new TextBox();
            btnSave = new Button();
            gridCellEdit = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridCellEdit).BeginInit();
            SuspendLayout();
            // 
            // tbxInEdit
            // 
            tbxInEdit.Location = new Point(303, 85);
            tbxInEdit.Name = "tbxInEdit";
            tbxInEdit.Size = new Size(171, 23);
            tbxInEdit.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(349, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "save";
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
            // 
            // editUsersListCell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridCellEdit);
            Controls.Add(btnSave);
            Controls.Add(tbxInEdit);
            Name = "editUsersListCell";
            Text = "editUsersListCell";
            ((System.ComponentModel.ISupportInitialize)gridCellEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxInEdit;
        private Button btnSave;
        private DataGridView gridCellEdit;
    }
}