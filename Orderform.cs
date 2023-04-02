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
    public partial class Orderform : Form
    {
        public Orderform()
        {
            InitializeComponent();
        }

        //---------------------------------------------Methods------------------------------------------------------------------------------

        public double CostOfItem()
        {
            double sum = 0;
            int i = 0;

            for (i = 0; i < (dataGridView1.Rows.Count); i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }

            return sum;
        }


        private void AddCost()
        {
            double tax, q;
            tax = 3.9;

            if (dataGridView1.Rows.Count > 0)
            {
                lblTheTax.Text = String.Format("{0}", (((CostOfItem() * tax) / 100)));
                lblSub.Text = String.Format("{0}", (CostOfItem()));
                q = ((CostOfItem() * tax) / 100);
                lblTheTotal.Text = String.Format("{0}", ((CostOfItem() + q)));
            }
        }

        private void Change()
        {
            double tax, q, c;
            tax = 3.9;

            if (dataGridView1.Rows.Count > 0)
            {
                q = ((CostOfItem() * tax) / 100) + CostOfItem();
                c = Convert.ToInt32(lblTheCost.Text);
                lblChangeReturned.Text = string.Format("{0}", c - q);
            }
        }


        //----------------------------------------------Methods------------------------------------------------------------------------------


        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                lblTheCost.Text = "0";
                lblChangeReturned.Text = "";
                lblSub.Text = "";
                lblTheTax.Text = "";
                lblTheTotal.Text = "";
                dataGridView1.Rows.Clear();
                cboPayment.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Orderform_Load(object sender, EventArgs e)
        {
            cboPayment.Items.Add("Cash");
            cboPayment.Items.Add("Visa Card");
            cboPayment.Items.Add("Master Card");
        }

        private void NumbersOnly(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (lblTheCost.Text == "0")
            {
                lblTheCost.Text = b.Text;
            }
            else if (b.Text == ".")
            {
                if (!lblTheCost.Text.Contains("."))
                {
                    lblTheCost.Text = lblTheCost.Text + b.Text;
                }
            }
            else
            {
                lblTheCost.Text = lblTheCost.Text + b.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTheCost.Text = "0";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            if (cboPayment.Text == "Cash")
            {
                if (double.Parse(lblTheCost.Text) > double.Parse(lblTheTotal.Text))
                {
                    {
                        Change();
                        MessageBox.Show("Payment was successful!");
                    }
                }
                else
                {
                    MessageBox.Show("Please input a value higher or equal to the total cost!");
                    lblTheCost.Text = "0";
                    lblChangeReturned.Text = "";
                }
            }
            else
            {
                lblChangeReturned.Text = "R 0.00";
                lblTheCost.Text = lblTheTotal.Text;
                MessageBox.Show("Payment was successful!");

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                try
                {
                    dataGridView1.Rows.Remove(row);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            AddCost();
            if (cboPayment.Text == "Cash")
            {
                Change();
            }
            else
            {
                lblChangeReturned.Text = "";
                lblTheCost.Text = "0";
            }
        }


        private void btnPancakes_Click(object sender, EventArgs e)
        {
            Double CostofItem = 29.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Pancakes")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Pancakes", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Pancakes", 1, CostofItem);
            }

            AddCost();
        }

        private void btnBurgerChips_Click(object sender, EventArgs e)
        {
            Double CostofItem = 39.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Burger and Chips")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Burger and Chips", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Burger and Chips", 1, CostofItem);
            }

            AddCost();
        }

        private void btnChickenWings_Click(object sender, EventArgs e)
        {
            Double CostofItem = 34.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Chicken Wings")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Chicken Wings", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Chicken Wings", 1, CostofItem);
            }

            AddCost();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            Double CostofItem = 35.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Pizza and Salad")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Pizza and Salad", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Pizza and Salad", 1, CostofItem);
            }

            AddCost();
        }

        private void btnDoritos_Click(object sender, EventArgs e)
        {
            Double CostofItem = 9.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Doritos")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Doritos", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Doritos", 1, CostofItem);
            }

            AddCost();
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            Double CostofItem = 9.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Fries")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Fries", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Fries", 1, CostofItem);
            }

            AddCost();
        }

        private void btnRedBull_Click(object sender, EventArgs e)
        {
            Double CostofItem = 17.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Red-Bull")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Red-Bull", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Red-Bull", 1, CostofItem);
            }

            AddCost();
        }

        private void btnSnicker_Click(object sender, EventArgs e)
        {
            Double CostofItem = 9.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Snicker Energy Bar")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Snicker Energy Bar", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Snicker Energy Bar", 1, CostofItem);
            }

            AddCost();
        }

        private void btnMonster_Click(object sender, EventArgs e)
        {
            Double CostofItem = 20.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Monster Energy")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Monster Energy", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Monster Energy", 1, CostofItem);
            }

            AddCost();
        }

        private void btnEnergy_Click(object sender, EventArgs e)
        {
            Double CostofItem = 15.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Energy Shot")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Energy Shot", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Energy Shot", 1, CostofItem);
            }

            AddCost();
        }

        private void btnCoke_Click(object sender, EventArgs e)
        {
            Double CostofItem = 14.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Coke")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Coke", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Coke", 1, CostofItem);
            }

            AddCost();
        }

        private void btnSprite_Click(object sender, EventArgs e)
        {
            Double CostofItem = 15.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Sprite")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Sprite", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Sprite", 1, CostofItem);
            }

            AddCost();
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            Double CostofItem = 14.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Fanta")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Fanta", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Fanta", 1, CostofItem);
            }

            AddCost();
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            Double CostofItem = 17.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Coffee and Cream")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Coffee and Cream", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Coffee and Cream", 1, CostofItem);
            }

            AddCost();
        }

        private void btnDonuts_Click(object sender, EventArgs e)
        {
            Double CostofItem = 8.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Donuts")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Donuts", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Donuts", 1, CostofItem);
            }

            AddCost();
        }

        private void btnKitKat_Click(object sender, EventArgs e)
        {
            Double CostofItem = 9.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Kit-Kat")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Kit-Kat", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Kit-Kat", 1, CostofItem);
            }

            AddCost();
        }

        private void btnCandyFloss_Click(object sender, EventArgs e)
        {
            Double CostofItem = 4.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Candy-Floss")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Candy-Floss", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Candy-Floss", 1, CostofItem);
            }

            AddCost();
        }

        private void btnBurgerCombo_Click(object sender, EventArgs e)
        {
            Double CostofItem = 89.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Burger Combo")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Burger Combo", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Burger Combo", 1, CostofItem);
            }

            AddCost();
        }

        private void btnBreakfastSpecial_Click(object sender, EventArgs e)
        {
            Double CostofItem = 95.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Breakfast Special")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Breakfast Special", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Breakfast Special", 1, CostofItem);
            }

            AddCost();
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            Double CostofItem = 64.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Combo Box")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Combo Box", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Combo Box", 1, CostofItem);
            }

            AddCost();
        }

        private void btnChefsTreat_Click(object sender, EventArgs e)
        {
            Double CostofItem = 100;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Chefs Treat")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Chefs Treat", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Chefs Treat", 1, CostofItem);
            }

            AddCost();
        }

        private void btnPringles_Click(object sender, EventArgs e)
        {
            Double CostofItem = 25.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Pringles")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Pringles", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Pringles", 1, CostofItem);
            }

            AddCost();
        }

        private void btnOrbit_Click(object sender, EventArgs e)
        {
            Double CostofItem = 11.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Orbit")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Orbit", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Orbit", 1, CostofItem);
            }

            AddCost();
        }

        private void btninforemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When removing data, move the cursor to the left most part of the Grid and click on the small block, " +
               " so that the entire row is highlighted.", "How to remove data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double CostofItem = 27.99;
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == "Milkshake")
                    {
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        row.Cells[2].Value = Convert.ToString(CostofItem * Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add("Milkshake", 1, CostofItem);
                }
            }
            else
            {
                dataGridView1.Rows.Add("Milkshake", 1, CostofItem);
            }

            AddCost();
        }

        private void btnmaininfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Firstly, navigate through the different items in the menu , such as bi and surges, each of this " +
              " sections is different categories of food that you can order , so if you see something that you like you simply" +
              " click on the icon.\n \r You can choose how many you want and when you see that you lost your apetite , you can simply" +
              " click on the reset button.\n \r IF you accidently clicked on a product that you dont want simply click on the product from" +
              " the datagrid and remove it. \n \r [If at any point you dont understand something click on the info buttons right next to the main" +
              " buttons]", "Welcome to the menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnresetinfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If at any point you want to remove all of the data from the datagrid and the transactions" +
               " Simply click on the reset button", "How to reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnpayinfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you are happy with the items added in your cart , as well as the total displayed in the teller screen" +
                " simply choose your payment method and click pay.", "How to Pay", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btnback1_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
        }

        private void Btnback2_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
        }

        private void Btnback4_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
        }

        private void Btnback5_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
        }

        private void Btnback6_Click(object sender, EventArgs e)
        {

        }
        public void declaration()
        {
            MessageBox.Show("When choosing a product click on any one of the icons that you desire, \n \r [One Click = 1 item] \n \r " +
               "If you are satisfied with your choice click on the back to main button", "Choosing a product", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            declaration();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            declaration();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            declaration();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            declaration();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            declaration();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            declaration();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show(this);
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ProfileForm frm = new ProfileForm();
            frm.Show(this);
            this.Hide();
        }
    }
}
