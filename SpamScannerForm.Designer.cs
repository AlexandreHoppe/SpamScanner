namespace SpamScanner
{
    partial class SpamScannerForm
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
            this.emailText = new System.Windows.Forms.TextBox();
            this.scanEmailButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailText
            // 
            this.emailText.AllowDrop = true;
            this.emailText.Location = new System.Drawing.Point(12, 12);
            this.emailText.Multiline = true;
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(535, 238);
            this.emailText.TabIndex = 0;
            // 
            // scanEmailButton
            // 
            this.scanEmailButton.Location = new System.Drawing.Point(203, 256);
            this.scanEmailButton.Name = "scanEmailButton";
            this.scanEmailButton.Size = new System.Drawing.Size(75, 23);
            this.scanEmailButton.TabIndex = 1;
            this.scanEmailButton.Text = "Scan";
            this.scanEmailButton.UseVisualStyleBackColor = true;
            this.scanEmailButton.Click += new System.EventHandler(this.scanEmailButton_Click);
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(284, 256);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(75, 23);
            this.listButton.TabIndex = 2;
            this.listButton.Text = "Show the list";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(122, 256);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(365, 256);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SpamScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 289);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.scanEmailButton);
            this.Controls.Add(this.emailText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SpamScannerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Scan For Spam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button scanEmailButton;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button closeButton;
    }
}

