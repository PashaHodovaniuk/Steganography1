namespace Steganography
{
    partial class Helper
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
            this.Helping = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Helping
            // 
            this.Helping.Location = new System.Drawing.Point(0, 0);
            this.Helping.Name = "Helping";
            this.Helping.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Helping.Size = new System.Drawing.Size(954, 498);
            this.Helping.TabIndex = 0;
            this.Helping.Text = "";
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 498);
            this.Controls.Add(this.Helping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Helper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Helper";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox Helping;

    }
}