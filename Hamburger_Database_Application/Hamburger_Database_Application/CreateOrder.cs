using Hamburger_Database_Application.Classes;
using Hamburger_Database_Application.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger_Database_Application
{
    public partial class CreateOrder : Form
    {
        ApplicationDbContext _db;
        Food selectedFood;
        List<Extra> selectedExtras;
        OrderList selectedOrder;

        public CreateOrder(ApplicationDbContext db)
        {
            InitializeComponent();
            _db = db;
            dgvFoodList.DataSource = _db.Foods.ToList();
            dgvExtraList.DataSource = _db.Extras.ToList();
            dgvOrderList.DataSource = _db.OrderLists.ToList();
            dgvOrderList.Columns["Extras"].Visible = false;
            selectedExtras = new List<Extra>();
            rdBtnSmall.Checked = true;
            nmrcUdQuantity.Value = 1;

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedFood != null)
                {
                    OrderList order = new OrderList();
                    order.Food = selectedFood;
                    if (rdBtnLarge.Checked)
                    {
                        order.Size = Classes.Size.Large;
                    }
                    else if (rdBtnMedium.Checked)
                    {
                        order.Size = Classes.Size.Medium;
                    }
                    else
                    {
                        order.Size = Classes.Size.Small;
                    }
                    order.FoodQuantity = Convert.ToInt32(nmrcUdQuantity.Value);

                    order.Extras = selectedExtras;

                    string extraNames = "";
                    foreach (Extra extra in order.Extras)
                    {
                        extraNames += extra.Name + ", ";
                    }

                    extraNames = extraNames.Trim().Trim(',');
                    order.ExtraNames = extraNames;
                    extraNames = "";

                    _db.OrderLists.Add(order);
                    selectedOrder = order;
                    _db.SaveChanges();

                    dgvOrderList.DataSource = _db.OrderLists.ToList();


                    MessageBox.Show("The order is added.");

                    CalculatePrice();
                }
                else
                {
                    MessageBox.Show("Please select a food.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }

        private void CalculatePrice()
        {
            decimal totalFoodPrice = 0;
            decimal totalExtraPrice = 0;
            decimal totalPrice = 0;

            foreach (OrderList order in _db.OrderLists)
            {
                if (order.Size == Classes.Size.Medium)
                {
                    totalFoodPrice += order.Food.Price * 1.25m;
                }
                else if (order.Size == Classes.Size.Large)
                {
                    totalFoodPrice += order.Food.Price * 1.50m;
                }
                else
                {
                    totalFoodPrice += order.Food.Price;
                }

                if (order.Extras != null)
                {
                    foreach (Extra extra in order.Extras)
                    {
                        totalExtraPrice += extra.Price;
                    }
                }


                totalPrice = order.FoodQuantity * (totalFoodPrice + totalExtraPrice);
            }

            lblTotalAmount.Text = totalPrice.ToString();
        }

        private void dgvFoodList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFood = _db.Foods.Find(Convert.ToInt32(dgvFoodList.Rows[e.RowIndex].Cells[0].Value));
        }

        private void dgvExtraList_SelectionChanged(object sender, EventArgs e)
        {
            selectedExtras.Clear();

            foreach (DataGridViewRow selectedRow in dgvExtraList.SelectedRows)
            {
                if (!selectedRow.IsNewRow)
                {
                    Extra selectedExtra = (Extra)selectedRow.DataBoundItem;
                    selectedExtras.Add(selectedExtra);
                }
            }
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {

            foreach (OrderList orderItem in _db.OrderLists)
            {
                Order order = new Order();
                order.Food = orderItem.Food;
                order.Size = orderItem.Size;
                order.FoodQuantity = orderItem.FoodQuantity;
                order.ExtraNames = orderItem.ExtraNames;
                order.Extras = orderItem.Extras;

                _db.Orders.Add(order);
            }


            List<OrderList> orderLists = _db.OrderLists.ToList();
            _db.OrderLists.RemoveRange(orderLists);
            _db.SaveChanges();
            dgvOrderList.DataSource = _db.OrderLists.ToList();
            lblTotalAmount.Text = "0";
            MessageBox.Show("Order has been finished.");
        }
    }
}
