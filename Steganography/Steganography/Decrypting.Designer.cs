namespace Steganography
{
    partial class Decrypting
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
            this.Img = new System.Windows.Forms.PictureBox();
            this.OpenImg = new System.Windows.Forms.Button();
            this.Key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenKey = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.TextEncr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exiting = new System.Windows.Forms.Button();
            this.MainScreenbut = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Help2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.SuspendLayout();
            // 
            // Img
            // 
            this.Img.BackColor = System.Drawing.Color.Transparent;
            this.Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Img.Location = new System.Drawing.Point(19, 17);
            this.Img.Margin = new System.Windows.Forms.Padding(10, 54, 0, 0);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(659, 528);
            this.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img.TabIndex = 1;
            this.Img.TabStop = false;
            // 
            // OpenImg
            // 
            this.OpenImg.BackColor = System.Drawing.Color.Transparent;
            this.OpenImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenImg.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenImg.ForeColor = System.Drawing.Color.ForestGreen;
            this.OpenImg.Location = new System.Drawing.Point(679, 44);
            this.OpenImg.Name = "OpenImg";
            this.OpenImg.Size = new System.Drawing.Size(304, 46);
            this.OpenImg.TabIndex = 2;
            this.OpenImg.Text = "Открыть картинку";
            this.OpenImg.UseVisualStyleBackColor = true;
            this.OpenImg.Click += new System.EventHandler(this.OpenImg_Click);
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(681, 187);
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Size = new System.Drawing.Size(304, 20);
            this.Key.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(681, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ключ";
            // 
            // OpenKey
            // 
            this.OpenKey.BackColor = System.Drawing.Color.Transparent;
            this.OpenKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenKey.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.OpenKey.ForeColor = System.Drawing.Color.SeaGreen;
            this.OpenKey.Location = new System.Drawing.Point(679, 96);
            this.OpenKey.Name = "OpenKey";
            this.OpenKey.Size = new System.Drawing.Size(304, 45);
            this.OpenKey.TabIndex = 9;
            this.OpenKey.Text = "Загрузить ключ";
            this.OpenKey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OpenKey.UseVisualStyleBackColor = true;
            this.OpenKey.Click += new System.EventHandler(this.OpenKey_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.Transparent;
            this.Decrypt.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decrypt.ForeColor = System.Drawing.Color.Red;
            this.Decrypt.Location = new System.Drawing.Point(681, 213);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(302, 49);
            this.Decrypt.TabIndex = 10;
            this.Decrypt.Text = "Дешифровка";
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // TextEncr
            // 
            this.TextEncr.HideSelection = false;
            this.TextEncr.Location = new System.Drawing.Point(681, 303);
            this.TextEncr.Multiline = true;
            this.TextEncr.Name = "TextEncr";
            this.TextEncr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextEncr.Size = new System.Drawing.Size(304, 106);
            this.TextEncr.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(681, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Сообщение";
            // 
            // Exiting
            // 
            this.Exiting.BackColor = System.Drawing.Color.Transparent;
            this.Exiting.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Exiting.ForeColor = System.Drawing.Color.SeaGreen;
            this.Exiting.Location = new System.Drawing.Point(835, 429);
            this.Exiting.Name = "Exiting";
            this.Exiting.Size = new System.Drawing.Size(150, 40);
            this.Exiting.TabIndex = 14;
            this.Exiting.Text = "Завершение";
            this.Exiting.UseVisualStyleBackColor = false;
            this.Exiting.Click += new System.EventHandler(this.Exiting_Click);
            // 
            // MainScreenbut
            // 
            this.MainScreenbut.BackColor = System.Drawing.Color.Transparent;
            this.MainScreenbut.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.MainScreenbut.ForeColor = System.Drawing.Color.SeaGreen;
            this.MainScreenbut.Location = new System.Drawing.Point(683, 429);
            this.MainScreenbut.Name = "MainScreenbut";
            this.MainScreenbut.Size = new System.Drawing.Size(150, 40);
            this.MainScreenbut.TabIndex = 13;
            this.MainScreenbut.Text = "Главное меню";
            this.MainScreenbut.UseVisualStyleBackColor = false;
            this.MainScreenbut.Click += new System.EventHandler(this.MainScreenbut_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Help2
            // 
            this.Help2.BackgroundImage = global::Steganography.Properties.Resources.help;
            this.Help2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Help2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help2.Location = new System.Drawing.Point(954, 5);
            this.Help2.Name = "Help2";
            this.Help2.Size = new System.Drawing.Size(37, 31);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.Help2});
            this.shapeContainer1.Size = new System.Drawing.Size(995, 567);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // Decrypting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Steganography.Properties.Resources.Substrates;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 567);
            this.Controls.Add(this.Exiting);
            this.Controls.Add(this.MainScreenbut);
            this.Controls.Add(this.TextEncr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.OpenKey);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenImg);
            this.Controls.Add(this.Img);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Decrypting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дешифровка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Decrypting_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.Button OpenImg;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenKey;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox TextEncr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exiting;
        private System.Windows.Forms.Button MainScreenbut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Help2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}