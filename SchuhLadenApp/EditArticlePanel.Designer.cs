namespace SchuhLadenApp
{
    partial class EditArticlePanel
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
            articleGridView = new DataGridView();
            btnEdit = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)articleGridView).BeginInit();
            SuspendLayout();
            // 
            // articleGridView
            // 
            articleGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            articleGridView.Location = new Point(12, 12);
            articleGridView.Name = "articleGridView";
            articleGridView.RowTemplate.Height = 25;
            articleGridView.Size = new Size(776, 393);
            articleGridView.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(673, 415);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // EditArticlePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnEdit);
            Controls.Add(articleGridView);
            Name = "EditArticlePanel";
            Text = "EditArticlePanel";
            ((System.ComponentModel.ISupportInitialize)articleGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView articleGridView;
        private Button btnEdit;
        private Button btnBack;
    }
}