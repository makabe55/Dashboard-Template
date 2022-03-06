namespace Master_of_PDF
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.panelSplitSubMenu = new System.Windows.Forms.Panel();
            this.btnExtractionSubMenu = new System.Windows.Forms.Button();
            this.btnSplitSubMenu = new System.Windows.Forms.Button();
            this.btnSplitAandExtraction = new System.Windows.Forms.Button();
            this.panelMargeSubMenu = new System.Windows.Forms.Panel();
            this.btnMargeSubMenu = new System.Windows.Forms.Button();
            this.btnMarge = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelSlideMenu.SuspendLayout();
            this.panelSplitSubMenu.SuspendLayout();
            this.panelMargeSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(150, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(567, 450);
            this.panelChildForm.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Location = new System.Drawing.Point(6, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(549, 346);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.AutoScroll = true;
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panelSlideMenu.Controls.Add(this.panelSplitSubMenu);
            this.panelSlideMenu.Controls.Add(this.btnSplitAandExtraction);
            this.panelSlideMenu.Controls.Add(this.panelMargeSubMenu);
            this.panelSlideMenu.Controls.Add(this.btnMarge);
            this.panelSlideMenu.Controls.Add(this.panelLogo);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSlideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(150, 450);
            this.panelSlideMenu.TabIndex = 1;
            // 
            // panelSplitSubMenu
            // 
            this.panelSplitSubMenu.AutoSize = true;
            this.panelSplitSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.panelSplitSubMenu.Controls.Add(this.btnExtractionSubMenu);
            this.panelSplitSubMenu.Controls.Add(this.btnSplitSubMenu);
            this.panelSplitSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSplitSubMenu.Location = new System.Drawing.Point(0, 229);
            this.panelSplitSubMenu.Name = "panelSplitSubMenu";
            this.panelSplitSubMenu.Size = new System.Drawing.Size(150, 81);
            this.panelSplitSubMenu.TabIndex = 5;
            // 
            // btnExtractionSubMenu
            // 
            this.btnExtractionSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtractionSubMenu.FlatAppearance.BorderSize = 0;
            this.btnExtractionSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractionSubMenu.Font = new System.Drawing.Font("BIZ UDゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExtractionSubMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExtractionSubMenu.Location = new System.Drawing.Point(0, 40);
            this.btnExtractionSubMenu.Name = "btnExtractionSubMenu";
            this.btnExtractionSubMenu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExtractionSubMenu.Size = new System.Drawing.Size(150, 41);
            this.btnExtractionSubMenu.TabIndex = 3;
            this.btnExtractionSubMenu.Text = "抽出";
            this.btnExtractionSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtractionSubMenu.UseVisualStyleBackColor = true;
            this.btnExtractionSubMenu.Click += new System.EventHandler(this.btnExtractionSubMenu_Click);
            // 
            // btnSplitSubMenu
            // 
            this.btnSplitSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSplitSubMenu.FlatAppearance.BorderSize = 0;
            this.btnSplitSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplitSubMenu.Font = new System.Drawing.Font("BIZ UDゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSplitSubMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSplitSubMenu.Location = new System.Drawing.Point(0, 0);
            this.btnSplitSubMenu.Name = "btnSplitSubMenu";
            this.btnSplitSubMenu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSplitSubMenu.Size = new System.Drawing.Size(150, 40);
            this.btnSplitSubMenu.TabIndex = 2;
            this.btnSplitSubMenu.Text = "分割";
            this.btnSplitSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSplitSubMenu.UseVisualStyleBackColor = true;
            this.btnSplitSubMenu.Click += new System.EventHandler(this.btnSplitSubMenu_Click);
            // 
            // btnSplitAandExtraction
            // 
            this.btnSplitAandExtraction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSplitAandExtraction.FlatAppearance.BorderSize = 0;
            this.btnSplitAandExtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplitAandExtraction.Font = new System.Drawing.Font("BIZ UDゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSplitAandExtraction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSplitAandExtraction.Location = new System.Drawing.Point(0, 186);
            this.btnSplitAandExtraction.Name = "btnSplitAandExtraction";
            this.btnSplitAandExtraction.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSplitAandExtraction.Size = new System.Drawing.Size(150, 43);
            this.btnSplitAandExtraction.TabIndex = 4;
            this.btnSplitAandExtraction.Text = "ページ分割/抽出";
            this.btnSplitAandExtraction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSplitAandExtraction.UseVisualStyleBackColor = true;
            this.btnSplitAandExtraction.Click += new System.EventHandler(this.btnSplitAandExtraction_Click);
            // 
            // panelMargeSubMenu
            // 
            this.panelMargeSubMenu.AutoSize = true;
            this.panelMargeSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.panelMargeSubMenu.Controls.Add(this.btnMargeSubMenu);
            this.panelMargeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMargeSubMenu.Location = new System.Drawing.Point(0, 143);
            this.panelMargeSubMenu.Name = "panelMargeSubMenu";
            this.panelMargeSubMenu.Size = new System.Drawing.Size(150, 43);
            this.panelMargeSubMenu.TabIndex = 3;
            // 
            // btnMargeSubMenu
            // 
            this.btnMargeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMargeSubMenu.FlatAppearance.BorderSize = 0;
            this.btnMargeSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMargeSubMenu.Font = new System.Drawing.Font("BIZ UDゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMargeSubMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMargeSubMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMargeSubMenu.Name = "btnMargeSubMenu";
            this.btnMargeSubMenu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMargeSubMenu.Size = new System.Drawing.Size(150, 43);
            this.btnMargeSubMenu.TabIndex = 2;
            this.btnMargeSubMenu.Text = "結合";
            this.btnMargeSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMargeSubMenu.UseVisualStyleBackColor = true;
            this.btnMargeSubMenu.Click += new System.EventHandler(this.btnMargeSubMenu_Click);
            // 
            // btnMarge
            // 
            this.btnMarge.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarge.FlatAppearance.BorderSize = 0;
            this.btnMarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarge.Font = new System.Drawing.Font("BIZ UDゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMarge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMarge.Location = new System.Drawing.Point(0, 100);
            this.btnMarge.Name = "btnMarge";
            this.btnMarge.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMarge.Size = new System.Drawing.Size(150, 43);
            this.btnMarge.TabIndex = 0;
            this.btnMarge.Text = "ページ結合";
            this.btnMarge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarge.UseVisualStyleBackColor = true;
            this.btnMarge.Click += new System.EventHandler(this.btnMarge_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(195)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSlideMenu);
            this.MinimumSize = new System.Drawing.Size(377, 310);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelSlideMenu.ResumeLayout(false);
            this.panelSlideMenu.PerformLayout();
            this.panelSplitSubMenu.ResumeLayout(false);
            this.panelMargeSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Panel panelSplitSubMenu;
        private System.Windows.Forms.Button btnExtractionSubMenu;
        private System.Windows.Forms.Button btnSplitSubMenu;
        private System.Windows.Forms.Button btnSplitAandExtraction;
        private System.Windows.Forms.Panel panelMargeSubMenu;
        private System.Windows.Forms.Button btnMargeSubMenu;
        private System.Windows.Forms.Button btnMarge;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

