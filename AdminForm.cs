using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group8_PRG281_Project
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        //Closes the admin form and opens the add user form
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddUserForm frm = new AddUserForm();
            frm.Show(this);
            this.Hide();
        }

        //Closes the admin form and opens the remove user form
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            RemoveUserForm frm = new RemoveUserForm();
            frm.Show(this);
            this.Hide();
        }

        //Closes the admin form and opens the stock take form
        private void BtnStock_Click(object sender, EventArgs e)
        {
            StockTakeForm frm = new StockTakeForm();
            frm.Show(this);
            this.Hide();
        }

        //Closes the entire application
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateOrders frm = new UpdateOrders();
            frm.Show(this);
            this.Hide();
        }

        private void LblHome_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show(this);
            this.Hide();
        }
    }
}
