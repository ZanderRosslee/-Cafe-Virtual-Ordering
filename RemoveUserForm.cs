using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Group8_PRG281_Project
{
    public partial class RemoveUserForm : Form
    {
        static string dbConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + Application.StartupPath + "/Project2.accdb";
        public RemoveUserForm()
        {
            InitializeComponent();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            AdminForm frm = new AdminForm();
            frm.Show(this);
            this.Hide();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            DialogResult showMessage = MessageBox.Show("Are you sure you want to remove this user", "Please select an option",
                                       MessageBoxButtons.YesNo);

            switch (showMessage)
            {
                case DialogResult.Yes:
                    try
                    {
                        //creates a new database connection using the built in OleDb Method
                        OleDbConnection myDbConn = new OleDbConnection(dbConnection);

                        OleDbCommand writeData = myDbConn.CreateCommand();

                        myDbConn.Open();
                        //sql statement to remove the record from the respective table
                        writeData = new OleDbCommand("DELETE FROM User WHERE UserName = " + TbxName.Text.ToString() + "AND UserSurname =" +
                                                     TbxSurname.Text.ToString() + "PhoneNumber = " + TbxPhoneNumber.Text.ToString());
                        writeData.ExecuteNonQuery();
                        MessageBox.Show("The record was sucessfully deleted");

                        myDbConn.Close();
                    }
                    catch (Exception f)
                    {
                        //executes an error message if the specific record couldn't be removed from the table
                        MessageBox.Show("Error: " + f.Message);
                    }
                    break;
                case DialogResult.No:

                    break;
                default:

                    break;
            }
        }

        private void LblHome_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show(this);
            this.Hide();
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            AdminForm frm = new AdminForm();
            frm.Show(this);
            this.Hide();
        }
    }
}
