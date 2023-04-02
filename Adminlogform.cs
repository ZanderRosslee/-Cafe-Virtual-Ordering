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
    public partial class Adminlogform : Form
    {
        public Adminlogform()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string[,] users = new string[,] { { "@", "a" }, { "0@belgiumcampus.ac.za", "123" } };

            string email, pass;
            bool login = false;
            bool emailCondition = false;
            bool passwordCondition = false;
            email = TbxEmail.Text;
            pass = TbxPassword.Text;


            while (login == false)
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Email or Password field can't be empty", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                else
                {
                    foreach (var item in users)
                    {
                        if (email == item)
                        {
                            emailCondition = true;
                            break;
                        }
                    }
                    foreach (var item in users)
                    {
                        if (pass == item)
                        {
                            passwordCondition = true;
                            break;
                        }
                    }
                    if (passwordCondition == true && emailCondition == true)
                    {
                        AdminForm frm = new AdminForm(); 
                        frm.Show(this);
                        this.Hide();
                        break; 
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Email or password. Please try again!", "You sneaky", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TbxEmail.Clear();
                        TbxPassword.Clear();


                        break;
                    }
                }
            }
        }

        private void LblHome_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show(this);
            this.Hide();
        }
    }
}
