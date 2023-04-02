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
    public partial class AddUserForm : Form
    {
        public OleDbConnection connection = new OleDbConnection();

        public AddUserForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\Project 2.accdb; Persist Security Info = False;";
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            AdminForm frm = new AdminForm();
            frm.Show(this);
            this.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            {
                //asks the user if they would like to save the details or not
                DialogResult showMessage = MessageBox.Show("Are you sure you want to save these details?",
                                                           "Please select an option.", MessageBoxButtons.YesNo);

                //switch for the options given to the user
                switch (showMessage)
                {
                    case DialogResult.Yes:

                        //if the password enered by the user doesn't match the confirmation password
                        if (TbxPassword.Text.ToString() != TbxConfirmPassword.Text.ToString())
                        {
                            //notifies the user that the passwords entered didn't match
                            MessageBox.Show("The passwords you entered do not match, please check the passwords and try again!");
                        }

                        else
                        {
                            try
                            {
                                connection.Open();
                                OleDbCommand command = new OleDbCommand();
                                command.Connection = connection;

                                command.CommandText = "INSERT INTO UserTable (UserName,UserSurname,PhoneNumber,UserEmail,UserPassword) values('" + TbxName.Text + "', '" + TbxSurname.Text + "', '" + TbxPhoneNumber.Text + "', '" + TbxEmail.Text + "', '" + TbxPassword.Text + "')";
                                //executes the query given above
                                command.ExecuteNonQuery();
                                connection.Close();
                                MessageBox.Show("The data you entered was inserted successfully!");
                            }
                            //an exception if the data couldn't be added to the table
                            catch (Exception f)
                            {
                                //shows the certain execcution error message
                                MessageBox.Show("Error:" + f.Message);
                            }
                        }
                        break;
                    case DialogResult.No:

                        break;
                    default:
                        MessageBox.Show("Please select a option");
                        break;
                }
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
