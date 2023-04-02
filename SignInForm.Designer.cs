namespace Group8_PRG281_Project
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.PnlTop = new System.Windows.Forms.Panel();
            this.LblHome = new System.Windows.Forms.Label();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.LblSignIn = new System.Windows.Forms.Label();
            this.LblOne = new System.Windows.Forms.Label();
            this.LblTwo = new System.Windows.Forms.Label();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.ImgIcons = new System.Windows.Forms.PictureBox();
            this.ImgPizza = new System.Windows.Forms.PictureBox();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblMenu = new System.Windows.Forms.Label();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(8)))));
            this.PnlTop.Controls.Add(this.LblMenu);
            this.PnlTop.Controls.Add(this.LblHome);
            this.PnlTop.Location = new System.Drawing.Point(0, 43);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(800, 50);
            this.PnlTop.TabIndex = 1;
            // 
            // LblHome
            // 
            this.LblHome.AutoSize = true;
            this.LblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblHome.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHome.Location = new System.Drawing.Point(337, 12);
            this.LblHome.Name = "LblHome";
            this.LblHome.Size = new System.Drawing.Size(56, 29);
            this.LblHome.TabIndex = 0;
            this.LblHome.Text = "Home";
            this.LblHome.Click += new System.EventHandler(this.LblHome_Click);
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(8)))));
            this.PnlBottom.Location = new System.Drawing.Point(0, 499);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(800, 50);
            this.PnlBottom.TabIndex = 4;
            // 
            // LblSignIn
            // 
            this.LblSignIn.AutoSize = true;
            this.LblSignIn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSignIn.Location = new System.Drawing.Point(43, 192);
            this.LblSignIn.Name = "LblSignIn";
            this.LblSignIn.Size = new System.Drawing.Size(104, 35);
            this.LblSignIn.TabIndex = 5;
            this.LblSignIn.Text = "Sign In";
            // 
            // LblOne
            // 
            this.LblOne.AutoSize = true;
            this.LblOne.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOne.Location = new System.Drawing.Point(44, 227);
            this.LblOne.Name = "LblOne";
            this.LblOne.Size = new System.Drawing.Size(262, 25);
            this.LblOne.TabIndex = 6;
            this.LblOne.Text = "Please provide your email and";
            // 
            // LblTwo
            // 
            this.LblTwo.AutoSize = true;
            this.LblTwo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTwo.Location = new System.Drawing.Point(44, 252);
            this.LblTwo.Name = "LblTwo";
            this.LblTwo.Size = new System.Drawing.Size(92, 25);
            this.LblTwo.TabIndex = 7;
            this.LblTwo.Text = "password";
            // 
            // TbxEmail
            // 
            this.TbxEmail.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxEmail.Location = new System.Drawing.Point(115, 310);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(299, 33);
            this.TbxEmail.TabIndex = 10;
            this.TbxEmail.Text = "Email";
            // 
            // TbxPassword
            // 
            this.TbxPassword.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPassword.Location = new System.Drawing.Point(115, 372);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(299, 33);
            this.TbxPassword.TabIndex = 11;
            this.TbxPassword.Text = "Password";
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackColor = System.Drawing.Color.Black;
            this.BtnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignIn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.ForeColor = System.Drawing.Color.White;
            this.BtnSignIn.Location = new System.Drawing.Point(182, 430);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(124, 40);
            this.BtnSignIn.TabIndex = 12;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // ImgIcons
            // 
            this.ImgIcons.Image = ((System.Drawing.Image)(resources.GetObject("ImgIcons.Image")));
            this.ImgIcons.Location = new System.Drawing.Point(49, 295);
            this.ImgIcons.Name = "ImgIcons";
            this.ImgIcons.Size = new System.Drawing.Size(60, 123);
            this.ImgIcons.TabIndex = 9;
            this.ImgIcons.TabStop = false;
            // 
            // ImgPizza
            // 
            this.ImgPizza.Image = ((System.Drawing.Image)(resources.GetObject("ImgPizza.Image")));
            this.ImgPizza.Location = new System.Drawing.Point(470, 121);
            this.ImgPizza.Name = "ImgPizza";
            this.ImgPizza.Size = new System.Drawing.Size(314, 323);
            this.ImgPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPizza.TabIndex = 8;
            this.ImgPizza.TabStop = false;
            // 
            // ImgLogo
            // 
            this.ImgLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo.Image")));
            this.ImgLogo.Location = new System.Drawing.Point(12, -4);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(159, 146);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgLogo.TabIndex = 3;
            this.ImgLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Default :  0@belgiumcampus.ac.za";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Default : 123 ";
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblMenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(399, 12);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(0, 29);
            this.LblMenu.TabIndex = 1;
            this.LblMenu.Click += new System.EventHandler(this.LblMenu_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.ImgIcons);
            this.Controls.Add(this.ImgPizza);
            this.Controls.Add(this.LblTwo);
            this.Controls.Add(this.LblOne);
            this.Controls.Add(this.LblSignIn);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.ImgLogo);
            this.Controls.Add(this.PnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label LblHome;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Label LblSignIn;
        private System.Windows.Forms.Label LblOne;
        private System.Windows.Forms.Label LblTwo;
        private System.Windows.Forms.PictureBox ImgPizza;
        private System.Windows.Forms.PictureBox ImgIcons;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblMenu;
    }
}