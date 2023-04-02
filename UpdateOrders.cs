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
    public partial class UpdateOrders : Form
    {
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Project 2.accdb";
        OleDbConnection dbConnection = new OleDbConnection(connectionString);
        public UpdateOrders()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_2DataSet2.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter1.Fill(this.project_2DataSet2.Orders);
            //rbPanel.Visible = false;
        }


        private void dgvRefresh_Click(object sender, EventArgs e)
        {
            string SQLSelect = null;

            SQLSelect = "SELECT * FROM Orders";

            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(SQLSelect, dbConnection);
            DataSet ds = new DataSet();
            dbConnection.Open();
            DataAdapter.Fill(ds, "Orders");
            dbConnection.Close();
            dgvView.DataSource = ds;
            dgvView.DataMember = "Orders";

            rbPanel.Visible = false;

            tbxCustSearch.Text = null;
            tbxOrderSearch.Text = null;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string SQLSelect;
            int OrderID;
            DialogResult dRes;

            OrderID = Convert.ToInt32(tbxOrderSearch.Text);
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();
            connection = new OleDbConnection(connectionString);


            SQLSelect = "DELETE FROM Orders WHERE OrderID = " + OrderID;

            dRes = MessageBox.Show("Delete confirmation", "Are you sure you want to delete this order?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            try
            {
                if (dRes == DialogResult.Yes)
                {
                    connection.Open();
                    oledbAdapter.DeleteCommand = connection.CreateCommand();
                    oledbAdapter.DeleteCommand.CommandText = SQLSelect;
                    oledbAdapter.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Order Deleted!");
                    dbConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string SQLSelect, Customer;
            int Product, Quantity, OrderID;
            int Total;

            if (rbPanel.Visible == false)
            {
                string Message = "You have to find the record beforehand to make sure you update the right record";
                string Title = "Before you do that";
                MessageBox.Show(Message, Title);
            }
            else
            {
                //OleDbCommand Command = new OleDbCommand(SQLSelect, dbConnection);
                //OleDbDataAdapter DataAdapter = new OleDbDataAdapter(SQLSelect, dbConnection);
                //DataSet ds = new DataSet();
                //dbConnection.Open();
                //DataAdapter.UpdateCommand = Command;
                //DataAdapter.Update();
                //dbConnection.Close();
                //dgvView.DataSource = ds;

                Customer = tbxCust.Text;
                Product = Convert.ToInt32(tbxProd.Text);
                Quantity = Convert.ToInt32(tbxQuant.Text);
                Total = Convert.ToInt32(tbxTotal.Text);
                OrderID = Convert.ToInt32(tbxOrderSearch.Text);

                OleDbConnection connection;
                OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();

                connection = new OleDbConnection(connectionString);
                SQLSelect = "UPDATE Orders SET CustomerID = '" + Customer + "', ProductID = " + Product +
                    ", Quantity = " + Quantity + ", Total = " + Total + ", WHERE OrderID = " + OrderID;
                OleDbCommand cmdUpdate = new OleDbCommand(SQLSelect, dbConnection);
                try
                {

                    cmdUpdate = new OleDbCommand();
                    cmdUpdate.CommandType = CommandType.Text;
                    cmdUpdate.CommandText = "UPDATE Orders SET CustomerID = @Customer, ProductID = @Product, " +
                        "Quantity = @Quantity, Total = @Total WHERE [OrderID] = @OrderID";

                    cmdUpdate.Parameters.AddWithValue("@Customer", tbxCust.Text);
                    cmdUpdate.Parameters.AddWithValue("@Product", Convert.ToInt32(tbxProd.Text));
                    cmdUpdate.Parameters.AddWithValue("@Quantity", Convert.ToInt32(tbxQuant.Text));
                    cmdUpdate.Parameters.AddWithValue("@Total", Convert.ToInt32(tbxTotal.Text));
                    cmdUpdate.Parameters.AddWithValue("@OrderID", Convert.ToInt32(tbxOrderSearch.Text));

                    cmdUpdate.Connection = dbConnection;
                    dbConnection.Open();
                    cmdUpdate.ExecuteNonQuery();
                    dbConnection.Close();


                    //oledbAdapter.UpdateCommand = connection.CreateCommand();
                    //oledbAdapter.UpdateCommand.CommandText = SQLSelect;
                    //oledbAdapter.UpdateCommand.ExecuteNonQuery();
                    //dbConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                dgvView.DataSource = null;
            }
        }

        private void BtnCusSearch_Click(object sender, EventArgs e)
        {
            string SQLSelect = null, CustomerID = null;

            CustomerID = tbxCustSearch.Text;
            SQLSelect = "SELECT * FROM Orders WHERE CustomerID = '" + CustomerID + "'";

            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(SQLSelect, dbConnection);
            DataSet ds = new DataSet();
            dbConnection.Open();
            DataAdapter.Fill(ds, "Orders");
            dbConnection.Close();
            dgvView.DataSource = ds;
            dgvView.DataMember = "Orders";

            Status.Text = "Query executed! Enter the correct order ID above to update the order!";
            rbPanel.Visible = false;
        }

        private void BtnOrderIDSearch_Click(object sender, EventArgs e)
        {
            int OrderID = 0;
            string SQLSelect = null;
            try
            {
                OrderID = Convert.ToInt32(tbxOrderSearch.Text);
            }
            catch (Exception)
            {
                Status.Text = "Field value is null or not a number.\r\nPlease enter a number and try again.";
                throw;
            }

            SQLSelect = "SELECT * FROM Orders WHERE OrderID = " + OrderID;

            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(SQLSelect, dbConnection);
            DataSet ds = new DataSet();
            dbConnection.Open();
            DataAdapter.Fill(ds, "Orders");
            dbConnection.Close();
            dgvView.DataSource = ds;
            dgvView.DataMember = "Orders";
            rbPanel.Visible = true;

            Status.Text = "Query executed!";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                SQLSelect = "SELECT * FROM Orders WHERE OrderID = " + Convert.ToInt32(tbxOrderSearch.Text);

                OleDbCommand command = new OleDbCommand(SQLSelect, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tbxCust.Text = (string)reader["CustomerID"];
                    tbxProd.Text = Convert.ToString((int)reader["ProductID"]);
                    tbxQuant.Text = Convert.ToString((int)reader["Quantity"]);
                    tbxTotal.Text = Convert.ToString((decimal)reader["Total"]);
                }
                reader.Close();
            }

            tbxCustSearch.Text = "";
        }

        private void ImgBack_Click(object sender, EventArgs e)
        {
            AdminForm frm = new AdminForm();
            frm.Show(this);
            this.Hide();
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
