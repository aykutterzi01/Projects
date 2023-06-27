using Hamburger_Database_Application.Classes;
using Hamburger_Database_Application.Context;
using Microsoft.EntityFrameworkCore;
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
    public partial class OrderDetails : Form
    {
        ApplicationDbContext _db;
        public OrderDetails(ApplicationDbContext db)
        {
            InitializeComponent();
            _db = db;
            dgvAllOrders.DataSource = _db.Orders.ToList();
            dgvAllOrders.Columns["Extras"].Visible = false;

            decimal revenue = 0;
            int totalNumberOfOrders = _db.Orders.Count();
            decimal totalIngredientRevenue = 0;
            int totalQuantity = 0;

            foreach (Order order in _db.Orders.Include(o => o.Food).Include(o => o.Extras))
            {
                decimal totalFoodPrice = 0;
                decimal ingredientRevenue = 0;
                totalQuantity += order.FoodQuantity;

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
                        ingredientRevenue += extra.Price;
                    }

                }

                revenue += order.FoodQuantity * (totalFoodPrice + ingredientRevenue);

                totalIngredientRevenue += ingredientRevenue * order.FoodQuantity;
            }

            lblRevenue.Text = revenue.ToString();
            lblQuantity.Text = totalNumberOfOrders.ToString();
            lblExtraIngredientRevenue.Text = totalIngredientRevenue.ToString();
            lblTotalNumberOfProductsSold.Text = totalQuantity.ToString();
        }
    }
}
