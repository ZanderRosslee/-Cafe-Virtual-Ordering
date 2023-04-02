using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group8_PRG281_Project
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            SignInForm frm = new SignInForm();
            frm.Show(this);
            this.Hide();
        }

        private void BtnSpecials_Click(object sender, EventArgs e)
        {
            SignInForm frm = new SignInForm();
            frm.Show(this);
            this.Hide();
        }

        private void LblSignIn_Click(object sender, EventArgs e)
        {
            SignInForm frm = new SignInForm();
            frm.Show(this);
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void LblMenu_Click(object sender, EventArgs e)
        {
            SignInForm frm = new SignInForm();
            frm.Show(this);
            this.Hide();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Adminlogform frm = new Adminlogform();
            frm.Show(this);
            this.Hide();
        }
    }
    
}
