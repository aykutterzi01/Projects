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

namespace Hamburger_Project
{
    public partial class OrderDetails : Form
    {
        List<Order> _allOrders;
        public OrderDetails(List<Order> allOrders)
        {
            InitializeComponent();
            _allOrders = allOrders;
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            ViewAllOrders(_allOrders);
            CalculateRevenue(_allOrders);
            lblTotalNumberOfOrders.Text = _allOrders.Count.ToString();
            CalculateTotalNumberOfProductsSold(_allOrders);

        }

        private void CalculateTotalNumberOfProductsSold(List<Order> allOrders)
        {
            int totalNumberOfProducts = 0;
            foreach (Order order in allOrders)
            {
                totalNumberOfProducts += order.MenuNumber;
            }

            lblTotalNumberOfProductsSold.Text = totalNumberOfProducts.ToString();
        }

        private void CalculateRevenue(List<Order> allOrders)
        {
            decimal revenue = 0;
            decimal extraRevenue = 0;

            foreach (Order order in allOrders)
            {

                if (order.MenuSize == MenuSize.Medium)
                {
                    revenue += (order.Menu.Price*1.25m) * order.MenuNumber;
                }
                else if (order.MenuSize == MenuSize.Large)
                {
                    revenue += (order.Menu.Price*1.50m) * order.MenuNumber;
                }
                else
                {
                    revenue += order.Menu.Price * order.MenuNumber;
                }

                foreach (Extra extra in order.Extras)
                {
                    extraRevenue += extra.Price * order.MenuNumber;
                }
            }

            revenue += extraRevenue;

            lblRevenue.Text = revenue.ToString();
            lblExtraIngeridentRevenue.Text = extraRevenue.ToString();
        }

        private void ViewAllOrders(List<Order> allOrders)
        {
            foreach (Order order in _allOrders)
            {
                string extraNames = "";
                foreach (Extra extra in order.Extras)
                {
                    extraNames += extra.Name + ", ";
                }

                lstBoxAllOrders.Items.Add(order.Menu.Name + " x " + order.MenuNumber + " " + order.MenuSize.ToString() + " (" + extraNames.Trim().Trim(',') + ")");
            }
        }
    }
}
