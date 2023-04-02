namespace Group8_PRG281_Project
{
    partial class StockTakeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockTakeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvStockTake = new System.Windows.Forms.DataGridView();
            this.BtnView = new System.Windows.Forms.Button();
            this.ImgBack = new System.Windows.Forms.PictureBox();
            this.LblHome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(8)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LblHome);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(8)))));
            this.panel2.Location = new System.Drawing.Point(0, 499);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(549, 40);
            this.button3.TabIndex = 33;
            this.button3.Text = "Stock Take Data";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dgvStockTake
            // 
            this.dgvStockTake.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockTake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockTake.Location = new System.Drawing.Point(12, 218);
            this.dgvStockTake.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStockTake.Name = "dgvStockTake";
            this.dgvStockTake.RowHeadersWidth = 62;
            this.dgvStockTake.RowTemplate.Height = 28;
            this.dgvStockTake.Size = new System.Drawing.Size(712, 213);
            this.dgvStockTake.TabIndex = 34;
            // 
            // BtnView
            // 
            this.BtnView.BackColor = System.Drawing.Color.Black;
            this.BtnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnView.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnView.ForeColor = System.Drawing.Color.White;
            this.BtnView.Location = new System.Drawing.Point(302, 445);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(124, 40);
            this.BtnView.TabIndex = 46;
            this.BtnView.Text = "View Data";
            this.BtnView.UseVisualStyleBackColor = false;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // ImgBack
            // 
            this.ImgBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgBack.Image = ((System.Drawing.Image)(resources.GetObject("ImgBack.Image")));
            this.ImgBack.Location = new System.Drawing.Point(12, 436);
            this.ImgBack.Name = "ImgBack";
            this.ImgBack.Size = new System.Drawing.Size(69, 63);
            this.ImgBack.TabIndex = 47;
            this.ImgBack.TabStop = false;
            this.ImgBack.Click += new System.EventHandler(this.ImgBack_Click);
            // 
            // LblHome
            // 
            this.LblHome.AutoSize = true;
            this.LblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblHome.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHome.Location = new System.Drawing.Point(410, 12);
            this.LblHome.Name = "LblHome";
            this.LblHome.Size = new System.Drawing.Size(56, 29);
            this.LblHome.TabIndex = 1;
            this.LblHome.Text = "Home";
            this.LblHome.Click += new System.EventHandler(this.LblHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "<---Back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StockTakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ImgBack);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.dgvStockTake);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockTakeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Take";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvStockTake;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.PictureBox ImgBack;
        private System.Windows.Forms.Label LblHome;
        private System.Windows.Forms.Label label1;
    }
}