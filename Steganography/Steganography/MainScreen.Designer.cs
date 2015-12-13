namespace Steganography
{
    partial class MainScreen
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.Help1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.label1 = new System.Windows.Forms.Label();
            this.Encrypting1 = new System.Windows.Forms.Label();
            this.Decrypting1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.Help1});
            this.shapeContainer1.Size = new System.Drawing.Size(874, 577);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // Help1
            // 
            this.Help1.BackgroundImage = global::Steganography.Properties.Resources.help;
            this.Help1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Help1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help1.Location = new System.Drawing.Point(833, 2);
            this.Help1.Name = "Help1";
            this.Help1.Size = new System.Drawing.Size(39, 34);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(209, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 201);
            this.label1.TabIndex = 1;
            this.label1.Text = "Программа\r\nСтеганографии";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Encrypting1
            // 
            this.Encrypting1.BackColor = System.Drawing.Color.Transparent;
            this.Encrypting1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encrypting1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encrypting1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Encrypting1.Location = new System.Drawing.Point(135, 361);
            this.Encrypting1.Name = "Encrypting1";
            this.Encrypting1.Size = new System.Drawing.Size(250, 94);
            this.Encrypting1.TabIndex = 2;
            this.Encrypting1.Text = "Шифровка";
            this.Encrypting1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Encrypting1.Click += new System.EventHandler(this.Encrypting1_Click);
            // 
            // Decrypting1
            // 
            this.Decrypting1.BackColor = System.Drawing.Color.Transparent;
            this.Decrypting1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrypting1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decrypting1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Decrypting1.Location = new System.Drawing.Point(503, 361);
            this.Decrypting1.Name = "Decrypting1";
            this.Decrypting1.Size = new System.Drawing.Size(250, 94);
            this.Decrypting1.TabIndex = 3;
            this.Decrypting1.Text = "Дешифровка";
            this.Decrypting1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Decrypting1.Click += new System.EventHandler(this.Decrypting1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Steganography.Properties.Resources.Substrates;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 577);
            this.Controls.Add(this.Decrypting1);
            this.Controls.Add(this.Encrypting1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Help1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Encrypting1;
        private System.Windows.Forms.Label Decrypting1;
    }
}

