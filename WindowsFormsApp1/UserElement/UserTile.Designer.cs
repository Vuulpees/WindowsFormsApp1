namespace WindowsFormsApp1.UserElement
{
    partial class UserTile
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(29, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Controls_Click);
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelName.Location = new System.Drawing.Point(29, 226);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(200, 55);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название";
            this.labelName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Controls_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelCost.Location = new System.Drawing.Point(30, 286);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(33, 13);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "Цена";
            this.labelCost.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Controls_Click);
            // 
            // UserTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserTile";
            this.Size = new System.Drawing.Size(260, 320);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Controls_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCost;
    }
}
