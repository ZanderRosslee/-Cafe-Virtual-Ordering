namespace Group8_PRG281_Project
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.PnlTop = new System.Windows.Forms.Panel();
            this.LblHome = new System.Windows.Forms.Label();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.LblProfile = new System.Windows.Forms.Label();
            this.ImgIcons = new System.Windows.Forms.PictureBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnSignOut = new System.Windows.Forms.Button();
            this.ImgDonut = new System.Windows.Forms.PictureBox();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDonut)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(8)))));
            this.PnlTop.Controls.Add(this.LblHome);
            this.PnlTop.Location = new System.Drawing.Point(0, 43);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(800, 50);
            this.PnlTop.TabIndex = 2;
            // 
            // LblHome
            // 
            this.LblHome.AutoSize = true;
            this.LblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblHome.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHome.Location = new System.Drawing.Point(311, 12);
            this.LblHome.Name = "LblHome";
            this.LblHome.Size = new System.Drawing.Size(56, 29);
            this.LblHome.TabIndex = 0;
            this.LblHome.Text = "Home";
            this.LblHome.Click += new System.EventHandler(this.LblHome_Click);
            // 
            // ImgLogo
            // 
            this.ImgLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo.Image")));
            this.ImgLogo.Location = new System.Drawing.Point(12, -4);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(159, 146);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgLogo.TabIndex = 4;
            this.ImgLogo.TabStop = false;
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(8)))));
            this.PnlBottom.Location = new System.Drawing.Point(0, 499);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(800, 50);
            this.PnlBottom.TabIndex = 5;
            // 
            // LblProfile
            // 
            this.LblProfile.AutoSize = true;
            this.LblProfile.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfile.Location = new System.Drawing.Point(43, 192);
            this.LblProfile.Name = "LblProfile";
            this.LblProfile.Size = new System.Drawing.Size(100, 35);
            this.LblProfile.TabIndex = 6;
            this.LblProfile.Text = "Profile";
            // 
            // ImgIcons
            // 
            this.ImgIcons.Image = ((System.Drawing.Image)(resources.GetObject("ImgIcons.Image")));
            this.ImgIcons.Location = new System.Drawing.Point(49, 242);
            this.ImgIcons.Name = "ImgIcons";
            this.ImgIcons.Size = new System.Drawing.Size(60, 111);
            this.ImgIcons.TabIndex = 7;
            this.ImgIcons.TabStop = false;
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxName.Location = new System.Drawing.Point(115, 251);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(299, 33);
            this.TbxName.TabIndex = 11;
            // 
            // TbxEmail
            // 
            this.TbxEmail.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxEmail.Location = new System.Drawing.Point(115, 315);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(299, 33);
            this.TbxEmail.TabIndex = 12;
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrder.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.ForeColor = System.Drawing.Color.White;
            this.BtnOrder.Location = new System.Drawing.Point(47, 442);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(263, 40);
            this.BtnOrder.TabIndex = 13;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnSignOut
            // 
            this.BtnSignOut.BackColor = System.Drawing.Color.Black;
            this.BtnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignOut.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignOut.ForeColor = System.Drawing.Color.White;
            this.BtnSignOut.Location = new System.Drawing.Point(316, 442);
            this.BtnSignOut.Name = "BtnSignOut";
            this.BtnSignOut.Size = new System.Drawing.Size(124, 40);
            this.BtnSignOut.TabIndex = 15;
            this.BtnSignOut.Text = "Sign Out";
            this.BtnSignOut.UseVisualStyleBackColor = false;
            this.BtnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // ImgDonut
            // 
            this.ImgDonut.Image = ((System.Drawing.Image)(resources.GetObject("ImgDonut.Image")));
            this.ImgDonut.Location = new System.Drawing.Point(479, 99);
            this.ImgDonut.Name = "ImgDonut";
            this.ImgDonut.Size = new System.Drawing.Size(306, 366);
            this.ImgDonut.TabIndex = 16;
            this.ImgDonut.TabStop = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ImgDonut);
            this.Controls.Add(this.BtnSignOut);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.ImgIcons);
            this.Controls.Add(this.LblProfile);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.ImgLogo);
            this.Controls.Add(this.PnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDonut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label LblHome;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Label LblProfile;
        private System.Windows.Forms.PictureBox ImgIcons;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnSignOut;
        private System.Windows.Forms.PictureBox ImgDonut;
    }
}