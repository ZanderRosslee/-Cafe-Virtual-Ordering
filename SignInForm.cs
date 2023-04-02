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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void LblHome_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show(this);
            this.Hide();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            

            string[,] users = new string[,] { { "@", "a" }, { "0@belgiumcampus.ac.za", "123" }, { "578551@student.belgiumcampus.ac.za", "Sibusisoadmin" }, { "578674@student.belgiumcampus.ac.za", "Dylanadmin" }, { "578420@student.belgiumcampus.ac.za", "Henkoadmin" }, { "578624@student.belgiumcampus.ac.za", "Jacquesadmin" }, { "578293@student.belgiumcampus.ac.za", "Zanderadmin" } };

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
                        ProfileForm frm = new ProfileForm();
                        frm.Show(this);
                        this.Hide();
                        if (string.IsNullOrEmpty(email))
                        {
                            MessageBox.Show("Welcome to #Cafe", "Hello Human", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Good Day " + email + ", Welcome to #Cafe", " Hello " + email, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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

        private void LblMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
