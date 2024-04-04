namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelNothing = new System.Windows.Forms.Label();
            this.buttonLeftx2 = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRightx2 = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.FLPTile = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.panel1.Location = new System.Drawing.Point(-183, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 10);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(302, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Просмотр продукции";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 12F);
            this.buttonExit.Location = new System.Drawing.Point(16, 28);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(144, 62);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label2.Location = new System.Drawing.Point(11, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поиск";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.textBoxSearch.Location = new System.Drawing.Point(168, 173);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(585, 36);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelNothing
            // 
            this.labelNothing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNothing.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.labelNothing.Location = new System.Drawing.Point(589, 567);
            this.labelNothing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNothing.Name = "labelNothing";
            this.labelNothing.Size = new System.Drawing.Size(63, 0);
            this.labelNothing.TabIndex = 6;
            this.labelNothing.Text = "Ничего не найдено";
            this.labelNothing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNothing.Visible = false;
            // 
            // buttonLeftx2
            // 
            this.buttonLeftx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.buttonLeftx2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeftx2.Location = new System.Drawing.Point(16, 341);
            this.buttonLeftx2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLeftx2.Name = "buttonLeftx2";
            this.buttonLeftx2.Size = new System.Drawing.Size(59, 73);
            this.buttonLeftx2.TabIndex = 7;
            this.buttonLeftx2.Text = "<<";
            this.buttonLeftx2.UseVisualStyleBackColor = false;
            this.buttonLeftx2.Click += new System.EventHandler(this.buttonLeftx2_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.buttonLeft.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.Location = new System.Drawing.Point(16, 431);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(59, 232);
            this.buttonLeft.TabIndex = 8;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRightx2
            // 
            this.buttonRightx2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRightx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.buttonRightx2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRightx2.Location = new System.Drawing.Point(1102, 320);
            this.buttonRightx2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRightx2.Name = "buttonRightx2";
            this.buttonRightx2.Size = new System.Drawing.Size(59, 79);
            this.buttonRightx2.TabIndex = 9;
            this.buttonRightx2.Text = ">>";
            this.buttonRightx2.UseVisualStyleBackColor = false;
            this.buttonRightx2.Click += new System.EventHandler(this.buttonRightx2_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.buttonRight.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.Location = new System.Drawing.Point(1102, 420);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(59, 243);
            this.buttonRight.TabIndex = 10;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCount.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(476, 667);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(236, 44);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "0 из 0 Товаров";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::WindowsFormsApp1.Properties.Resources.beauty_logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1061, 13);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 92);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FLPTile
            // 
            this.FLPTile.AutoScroll = true;
            this.FLPTile.Location = new System.Drawing.Point(103, 245);
            this.FLPTile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FLPTile.Name = "FLPTile";
            this.FLPTile.Size = new System.Drawing.Size(954, 418);
            this.FLPTile.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Title",
            "Cost"});
            this.comboBox1.Location = new System.Drawing.Point(774, 173);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(960, 173);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Убывание";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(498, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ничего не найдено";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 730);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonRightx2);
            this.Controls.Add(this.buttonLeftx2);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelNothing);
            this.Controls.Add(this.FLPTile);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(12, 23);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1594, 1121);
            this.MinimumSize = new System.Drawing.Size(700, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма продукции";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelNothing;
        private System.Windows.Forms.Button buttonLeftx2;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRightx2;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.FlowLayoutPanel FLPTile;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
    }
}

