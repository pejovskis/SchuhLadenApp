namespace SchuhLadenApp
{
    partial class Form1
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
            tbxTestInput = new TextBox();
            btnTestIn = new Button();
            tbxInput2 = new TextBox();
            SuspendLayout();
            // 
            // tbxTestInput
            // 
            tbxTestInput.Location = new Point(259, 107);
            tbxTestInput.Name = "tbxTestInput";
            tbxTestInput.Size = new Size(294, 23);
            tbxTestInput.TabIndex = 0;
            // 
            // btnTestIn
            // 
            btnTestIn.Location = new Point(371, 163);
            btnTestIn.Name = "btnTestIn";
            btnTestIn.Size = new Size(75, 23);
            btnTestIn.TabIndex = 1;
            btnTestIn.Text = "button1";
            btnTestIn.UseVisualStyleBackColor = true;
            btnTestIn.Click += button1_Click;
            // 
            // tbxInput2
            // 
            tbxInput2.Location = new Point(259, 66);
            tbxInput2.Name = "tbxInput2";
            tbxInput2.Size = new Size(294, 23);
            tbxInput2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxInput2);
            Controls.Add(btnTestIn);
            Controls.Add(tbxTestInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxTestInput;
        private Button btnTestIn;
        private TextBox tbxInput2;
    }
}