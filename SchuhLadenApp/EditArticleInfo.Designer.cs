namespace SchuhLadenApp
{
    partial class EditArticleInfo
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
            articleShowGrid = new DataGridView();
            btnUpdateArticle = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)articleShowGrid).BeginInit();
            SuspendLayout();
            // 
            // articleShowGrid
            // 
            articleShowGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            articleShowGrid.Location = new Point(52, 129);
            articleShowGrid.Name = "articleShowGrid";
            articleShowGrid.RowTemplate.Height = 25;
            articleShowGrid.Size = new Size(707, 93);
            articleShowGrid.TabIndex = 0;
            articleShowGrid.CellContentClick += articleShowGrid_CellContentClick;
            // 
            // btnUpdateArticle
            // 
            btnUpdateArticle.Location = new Point(447, 259);
            btnUpdateArticle.Name = "btnUpdateArticle";
            btnUpdateArticle.Size = new Size(114, 23);
            btnUpdateArticle.TabIndex = 1;
            btnUpdateArticle.Text = "update article";
            btnUpdateArticle.UseVisualStyleBackColor = true;
            btnUpdateArticle.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(245, 259);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(108, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += button2_Click;
            // 
            // EditArticleInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnUpdateArticle);
            Controls.Add(articleShowGrid);
            Name = "EditArticleInfo";
            Text = "EditArticleInfo";
            Load += EditArticleInfo_Load;
            ((System.ComponentModel.ISupportInitialize)articleShowGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView articleShowGrid;
        private Button btnUpdateArticle;
        private Button btnBack;
    }
}