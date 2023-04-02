namespace Group8_PRG281_Project
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.PnlTop = new System.Windows.Forms.Panel();
            this.LblSignIn = new System.Windows.Forms.Label();
            this.LblMenu = new System.Windows.Forms.Label();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblSub = new System.Windows.Forms.Label();
            this.LblFirst = new System.Windows.Forms.Label();
            this.LblSecond = new System.Windows.Forms.Label();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnSpecials = new System.Windows.Forms.Button();
            this.ImgBurger = new System.Windows.Forms.PictureBox();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBurger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(8)))));
            this.PnlTop.Controls.Add(this.LblSignIn);
            this.PnlTop.Controls.Add(this.LblMenu);
            this.PnlTop.Location = new System.Drawing.Point(0, 43);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(800, 50);
            this.PnlTop.TabIndex = 0;
            // 
            // LblSignIn
            // 
            this.LblSignIn.AutoSize = true;
            this.LblSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblSignIn.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSignIn.Location = new System.Drawing.Point(399, 12);
            this.LblSignIn.Name = "LblSignIn";
            this.LblSignIn.Size = new System.Drawing.Size(68, 29);
            this.LblSignIn.TabIndex = 1;
            this.LblSignIn.Text = "Sign In";
            this.LblSignIn.Click += new System.EventHandler(this.LblSignIn_Click);
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblMenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(311, 12);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(55, 29);
            this.LblMenu.TabIndex = 0;
            this.LblMenu.Text = "Menu";
            this.LblMenu.Click += new System.EventHandler(this.LblMenu_Click);
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(8)))));
            this.PnlBottom.Location = new System.Drawing.Point(0, 499);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(800, 50);
            this.PnlBottom.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(43, 192);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(286, 35);
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "Technology and Food";
            // 
            // LblSub
            // 
            this.LblSub.AutoSize = true;
            this.LblSub.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSub.Location = new System.Drawing.Point(44, 227);
            this.LblSub.Name = "LblSub";
            this.LblSub.Size = new System.Drawing.Size(323, 25);
            this.LblSub.TabIndex = 4;
            this.LblSub.Text = "is best when it brings people together";
            // 
            // LblFirst
            // 
            this.LblFirst.AutoSize = true;
            this.LblFirst.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirst.Location = new System.Drawing.Point(45, 313);
            this.LblFirst.Name = "LblFirst";
            this.LblFirst.Size = new System.Drawing.Size(188, 24);
            this.LblFirst.TabIndex = 5;
            this.LblFirst.Text = "The most delcious food";
            // 
            // LblSecond
            // 
            this.LblSecond.AutoSize = true;
            this.LblSecond.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSecond.Location = new System.Drawing.Point(45, 337);
            this.LblSecond.Name = "LblSecond";
            this.LblSecond.Size = new System.Drawing.Size(140, 24);
            this.LblSecond.TabIndex = 6;
            this.LblSecond.Text = "North of Pretoria";
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrder.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.ForeColor = System.Drawing.Color.White;
            this.BtnOrder.Location = new System.Drawing.Point(49, 406);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(124, 40);
            this.BtnOrder.TabIndex = 7;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnSpecials
            // 
            this.BtnSpecials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSpecials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSpecials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSpecials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSpecials.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSpecials.ForeColor = System.Drawing.Color.White;
            this.BtnSpecials.Location = new System.Drawing.Point(216, 406);
            this.BtnSpecials.Name = "BtnSpecials";
            this.BtnSpecials.Size = new System.Drawing.Size(124, 40);
            this.BtnSpecials.TabIndex = 8;
            this.BtnSpecials.Text = "Specials";
            this.BtnSpecials.UseVisualStyleBackColor = false;
            this.BtnSpecials.Click += new System.EventHandler(this.BtnSpecials_Click);
            // 
            // ImgBurger
            // 
            this.ImgBurger.Image = ((System.Drawing.Image)(resources.GetObject("ImgBurger.Image")));
            this.ImgBurger.Location = new System.Drawing.Point(429, 99);
            this.ImgBurger.Name = "ImgBurger";
            this.ImgBurger.Size = new System.Drawing.Size(355, 394);
            this.ImgBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBurger.TabIndex = 9;
            this.ImgBurger.TabStop = false;
            // 
            // ImgLogo
            // 
            this.ImgLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo.Image")));
            this.ImgLogo.Location = new System.Drawing.Point(12, -4);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(159, 146);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgLogo.TabIndex = 2;
            this.ImgLogo.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Black;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(49, 453);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(124, 40);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.Black;
            this.btnadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmin.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.Color.White;
            this.btnadmin.Location = new System.Drawing.Point(216, 453);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(124, 40);
            this.btnadmin.TabIndex = 11;
            this.btnadmin.Text = "Admin";
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.ImgBurger);
            this.Controls.Add(this.BtnSpecials);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.LblSecond);
            this.Controls.Add(this.LblFirst);
            this.Controls.Add(this.LblSub);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.ImgLogo);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.PnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHome";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBurger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label LblSignIn;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblSub;
        private System.Windows.Forms.Label LblFirst;
        private System.Windows.Forms.Label LblSecond;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnSpecials;
        private System.Windows.Forms.PictureBox ImgBurger;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnadmin;
    }
}

