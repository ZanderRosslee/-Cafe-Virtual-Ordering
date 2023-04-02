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
    public partial class StockTakeForm : Form
    {
        static string dbConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\project_2.mdb";
        public StockTakeForm()
        {
            InitializeComponent();
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            AdminForm frm = new AdminForm();
            frm.Show(this);
            this.Hide();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            DialogResult showMessage = MessageBox.Show("Would you like to view the stock taking data?",
                                                                   "Please select an option", MessageBoxButtons.YesNo);

            switch (showMessage)
            {
                case DialogResult.Yes:
                    try
                    {
                        OleDbConnection myDbConn = new OleDbConnection(dbConnection);
                        OleDbCommand writeData = new OleDbCommand();

                        myDbConn.Open();
                        writeData.Connection = myDbConn;
                        writeData.CommandText = "SELECT * FROM Stock";

                        OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(writeData);
                        DataSet stockTable = new DataSet();
                        dbDataAdapter.Fill(stockTable);
                        dgvStockTake.DataSource = "";
                        dgvStockTake.DataSource = stockTable.Tables[0];
                        myDbConn.Close();
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show("Error:" + f.Message);
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

        private void label1_Click(object sender, EventArgs e)
        {
            AdminForm frm = new AdminForm();
            frm.Show(this);
            this.Hide();
        }
    }
}
