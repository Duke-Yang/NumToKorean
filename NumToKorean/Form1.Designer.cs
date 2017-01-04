namespace NumToKorean
{
    partial class Form1
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
            this.TranslateButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TranslateButton
            // 
            this.TranslateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TranslateButton.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TranslateButton.Location = new System.Drawing.Point(101, 77);
            this.TranslateButton.Name = "TranslateButton";
            this.TranslateButton.Size = new System.Drawing.Size(154, 77);
            this.TranslateButton.TabIndex = 0;
            this.TranslateButton.Text = "Translate";
            this.TranslateButton.UseVisualStyleBackColor = true;
            this.TranslateButton.Click += new System.EventHandler(this.TranslateButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.Color.White;
            this.ResultBox.Font = new System.Drawing.Font("Gulim", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ResultBox.Location = new System.Drawing.Point(30, 183);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(302, 93);
            this.ResultBox.TabIndex = 1;
            this.ResultBox.Text = "KOREAN";
            this.ResultBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gulim", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(101, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 61);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(365, 309);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.TranslateButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TranslateButton;
        private System.Windows.Forms.Label ResultBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

