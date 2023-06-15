using Hamburger_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Size = Hamburger_Project.Classes.MenuSize;

namespace Hamburger_Project
{
    public partial class CreateOrder : Form
    {
        List<Menus> _menus;
        List<Extra> _extras;
        List<Order> _allOrders;
        List<Order> addedOrders;

        public CreateOrder(List<Menus> menus, List<Extra> extras, List<Order> allOrders)
        {
            InitializeComponent();
            _menus = menus;
            _extras = extras;
            _allOrders = allOrders;
            addedOrders = new List<Order>();
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            ListMenusInListBox(_menus);
            ListExtraIngredients(_extras);

            rdBtnSmall.Checked = true;
        }

        private void ListExtraIngredients(List<Extra> extras)
        {
            CheckBox checkBox;
            int i = 0;

            foreach (Extra extra in _extras)
            {
                checkBox = new CheckBox();
                checkBox.Text = extra.Name;
                checkBox.Location = new Point(10, i * 25);
                pnlIngredient.Controls.Add(checkBox);
                i++;
            }
        }

        private void ListMenusInListBox(List<Menus> menus)
        {
            foreach (Menus menu in _menus)
            {
                cmBoxMenu.Items.Add(menu.Name);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (cmBoxMenu.SelectedItem != null && nmrcUpDownNumber.Value >= 1)
            {
                CreateNewOrder();

            }
            else
            {
                MessageBox.Show("Please choose a menu and/or a number.");
            }

        }

        private void CreateNewOrder()
        {
            Order order = new Order();

            AddMenuToOrder(order);

            order.MenuNumber = (int)nmrcUpDownNumber.Value;

            AddMenuSizeToOrder(order);

            AddItemsToListBox(order);

            CalculateTotalAmount(order);

            addedOrders.Add(order);
        }

        private void CalculateTotalAmount(Order order)
        {
            decimal extraPrice = 0;

            foreach (CheckBox checkBox in pnlIngredient.Controls)
            {
                if (checkBox.Checked)
                {
                    foreach (Extra extra in _extras)
                    {
                        if (checkBox.Text == extra.Name)
                        {
                            extraPrice += extra.Price;
                        }
                    }
                }
            }

            decimal totalAmount = 0;

            if (order.MenuSize == MenuSize.Medium)
            {
                totalAmount += (order.Menu.Price * 1.25m + extraPrice) * order.MenuNumber;
            }
            else if (order.MenuSize == MenuSize.Large)
            {
                totalAmount += (order.Menu.Price * 1.50m + extraPrice) * order.MenuNumber;
            }
            else
            {
                totalAmount += (order.Menu.Price + extraPrice) * order.MenuNumber;
            }


            lblTotalAmount.Text = totalAmount.ToString();
        }

        private void AddItemsToListBox(Order order)
        {
            string ingredients = "";

            foreach (CheckBox checkBox in pnlIngredient.Controls)
            {
                if (checkBox.Checked)
                {
                    foreach (Extra extra in _extras)
                    {
                        if (checkBox.Text == extra.Name)
                        {
                            order.Extras.Add(extra);
                            ingredients += extra.Name + ", ";
                        }
                    }
                }
            }

            lstBoxOrders.Items.Add(order.Menu.Name + " x " + order.MenuNumber + ", " + order.MenuSize.ToString() + ", (" + ingredients.Trim().Trim(',') + ")");
        }

        private void AddMenuSizeToOrder(Order order)
        {
            foreach (RadioButton radioButton in groupBox1.Controls)
            {
                if (radioButton.Checked)
                {
                    order.MenuSize = radioButton.Text == "Small" ? MenuSize.Small : radioButton.Text == "Medium" ? MenuSize.Medium : MenuSize.Large;
                }
            }
        }

        private void AddMenuToOrder(Order order)
        {

            foreach (Menus menu in _menus)
            {
                if (menu.Name == cmBoxMenu.SelectedItem.ToString())
                {
                    order.Menu = menu;
                }
            }
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();

            result = MessageBox.Show("Total order amount is " + lblTotalAmount.Text + "₺\nWould you like to finish the order?", "Order Information", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _allOrders.AddRange(addedOrders);
                lstBoxOrders.Items.Clear();
                lblTotalAmount.Text = "0,00";
            }
            else
            {
                MessageBox.Show("Canceled!");
            }
        }
    }
}
