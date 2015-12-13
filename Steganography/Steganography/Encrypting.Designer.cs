namespace Steganography
{
    partial class Encrypting
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextEncr = new System.Windows.Forms.TextBox();
            this.AutoKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.TextBox();
            this.ClearKey = new System.Windows.Forms.Button();
            this.SaveKey = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveImg = new System.Windows.Forms.Button();
            this.Exiting = new System.Windows.Forms.Button();
            this.MainScreen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StartSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EndSize = new System.Windows.Forms.Label();
            this.Help1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            this.SuspendLayout();
            // 
            // Img
            // 
            this.Img.BackColor = System.Drawing.Color.Transparent;
            this.Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Img.Location = new System.Drawing.Point(19, 44);
            this.Img.Margin = new System.Windows.Forms.Padding(10, 54, 0, 0);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(659, 510);
            this.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img.TabIndex = 0;
            this.Img.TabStop = false;
            // 
            // OpenImg
            // 
            this.OpenImg.BackColor = System.Drawing.Color.Transparent;
            this.OpenImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenImg.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenImg.ForeColor = System.Drawing.Color.ForestGreen;
            this.OpenImg.Location = new System.Drawing.Point(681, 35);
            this.OpenImg.Name = "OpenImg";
            this.OpenImg.Size = new System.Drawing.Size(304, 46);
            this.OpenImg.TabIndex = 1;
            this.OpenImg.Text = "Открыть картинку";
            this.OpenImg.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(681, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сообщение";
            // 
            // TextEncr
            // 
            this.TextEncr.HideSelection = false;
            this.TextEncr.Location = new System.Drawing.Point(681, 118);
            this.TextEncr.Multiline = true;
            this.TextEncr.Name = "TextEncr";
            this.TextEncr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextEncr.Size = new System.Drawing.Size(304, 106);
            this.TextEncr.TabIndex = 3;
            // 
            // AutoKey
            // 
            this.AutoKey.BackColor = System.Drawing.Color.Transparent;
            this.AutoKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AutoKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoKey.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.AutoKey.ForeColor = System.Drawing.Color.SeaGreen;
            this.AutoKey.Location = new System.Drawing.Point(681, 230);
            this.AutoKey.Name = "AutoKey";
            this.AutoKey.Size = new System.Drawing.Size(304, 39);
            this.AutoKey.TabIndex = 4;
            this.AutoKey.Text = "Генерация ключа";
            this.AutoKey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AutoKey.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(681, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ключ";
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(681, 306);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(304, 20);
            this.Key.TabIndex = 6;
            // 
            // ClearKey
            // 
            this.ClearKey.BackColor = System.Drawing.Color.Transparent;
            this.ClearKey.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearKey.ForeColor = System.Drawing.Color.SeaGreen;
            this.ClearKey.Location = new System.Drawing.Point(681, 332);
            this.ClearKey.Name = "ClearKey";
            this.ClearKey.Size = new System.Drawing.Size(150, 40);
            this.ClearKey.TabIndex = 7;
            this.ClearKey.Text = "Очистить ключ";
            this.ClearKey.UseVisualStyleBackColor = false;
            // 
            // SaveKey
            // 
            this.SaveKey.BackColor = System.Drawing.Color.Transparent;
            this.SaveKey.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveKey.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveKey.Location = new System.Drawing.Point(833, 332);
            this.SaveKey.Name = "SaveKey";
            this.SaveKey.Size = new System.Drawing.Size(150, 40);
            this.SaveKey.TabIndex = 8;
            this.SaveKey.Text = "Сохранить ключ";
            this.SaveKey.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(681, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Шифровка";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SaveImg
            // 
            this.SaveImg.BackColor = System.Drawing.Color.Transparent;
            this.SaveImg.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveImg.ForeColor = System.Drawing.Color.ForestGreen;
            this.SaveImg.Location = new System.Drawing.Point(681, 433);
            this.SaveImg.Name = "SaveImg";
            this.SaveImg.Size = new System.Drawing.Size(302, 54);
            this.SaveImg.TabIndex = 10;
            this.SaveImg.Text = "Сохранить картинку";
            this.SaveImg.UseVisualStyleBackColor = false;
            // 
            // Exiting
            // 
            this.Exiting.BackColor = System.Drawing.Color.Transparent;
            this.Exiting.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Exiting.ForeColor = System.Drawing.Color.SeaGreen;
            this.Exiting.Location = new System.Drawing.Point(833, 493);
            this.Exiting.Name = "Exiting";
            this.Exiting.Size = new System.Drawing.Size(150, 40);
            this.Exiting.TabIndex = 12;
            this.Exiting.Text = "Завершение";
            this.Exiting.UseVisualStyleBackColor = false;
            // 
            // MainScreen
            // 
            this.MainScreen.BackColor = System.Drawing.Color.Transparent;
            this.MainScreen.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.MainScreen.ForeColor = System.Drawing.Color.SeaGreen;
            this.MainScreen.Location = new System.Drawing.Point(681, 493);
            this.MainScreen.Name = "MainScreen";
            this.MainScreen.Size = new System.Drawing.Size(150, 40);
            this.MainScreen.TabIndex = 11;
            this.MainScreen.Text = "Главное меню";
            this.MainScreen.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Размер файла до шифровки:";
            // 
            // StartSize
            // 
            this.StartSize.AutoSize = true;
            this.StartSize.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartSize.ForeColor = System.Drawing.Color.Red;
            this.StartSize.Location = new System.Drawing.Point(272, 18);
            this.StartSize.Name = "StartSize";
            this.StartSize.Size = new System.Drawing.Size(0, 22);
            this.StartSize.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(317, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "После:";
            // 
            // EndSize
            // 
            this.EndSize.AutoSize = true;
            this.EndSize.BackColor = System.Drawing.Color.Transparent;
            this.EndSize.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndSize.ForeColor = System.Drawing.Color.Red;
            this.EndSize.Location = new System.Drawing.Point(391, 18);
            this.EndSize.Name = "EndSize";
            this.EndSize.Size = new System.Drawing.Size(0, 22);
            this.EndSize.TabIndex = 16;
            // 
            // Help1
            // 
            this.Help1.BackgroundImage = global::Steganography.Properties.Resources.help;
            this.Help1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Help1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help1.Location = new System.Drawing.Point(478, 266);
            this.Help1.Name = "Help1";
            this.Help1.Size = new System.Drawing.Size(39, 34);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1,
            this.Help1});
            this.shapeContainer1.Size = new System.Drawing.Size(995, 567);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackgroundImage = global::Steganography.Properties.Resources.help;
            this.ovalShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ovalShape1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ovalShape1.Location = new System.Drawing.Point(962, 3);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(34, 29);
            // 
            // Encrypting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Steganography.Properties.Resources.Substrates;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 567);
            this.Controls.Add(this.EndSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exiting);
            this.Controls.Add(this.MainScreen);
            this.Controls.Add(this.SaveImg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveKey);
            this.Controls.Add(this.ClearKey);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AutoKey);
            this.Controls.Add(this.TextEncr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenImg);
            this.Controls.Add(this.Img);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Encrypting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифровка";
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.Button OpenImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextEncr;
        private System.Windows.Forms.Button AutoKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Button ClearKey;
        private System.Windows.Forms.Button SaveKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveImg;
        private System.Windows.Forms.Button Exiting;
        private System.Windows.Forms.Button MainScreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StartSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EndSize;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Help1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
    }
}