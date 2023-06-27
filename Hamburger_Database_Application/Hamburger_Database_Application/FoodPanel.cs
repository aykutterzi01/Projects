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
    public partial class FoodPanel : Form
    {
        ApplicationDbContext _db;
        Food selectedFood;
        public FoodPanel(ApplicationDbContext db)
        {
            InitializeComponent();
            _db = db;
            dgvFoods.DataSource = _db.Foods.ToList();
        }

        private void dgvFoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFood = _db.Foods.Find(Convert.ToInt32(dgvFoods.Rows[e.RowIndex].Cells[0].Value));

            txtBoxFoodName.Text = selectedFood.Name;
            nmrcUdFoodPrice.Value = selectedFood.Price;
        }

        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Food food = new Food();
                food.Name = txtBoxFoodName.Text;
                food.Price = nmrcUdFoodPrice.Value;

                _db.Foods.Add(food);
                _db.SaveChanges();
                MessageBox.Show("Food is added to the list.");
                dgvFoods.DataSource = _db.Foods.ToList();
                txtBoxFoodName.Text = "";
                nmrcUdFoodPrice.Value = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }

        private void btnFoodUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedFood != null)
                {
                    selectedFood.Name = txtBoxFoodName.Text;
                    selectedFood.Price = nmrcUdFoodPrice.Value;
                    _db.SaveChanges();
                    MessageBox.Show("Updated.");
                    dgvFoods.DataSource = _db.Foods.ToList();
                    selectedFood = null;
                    txtBoxFoodName.Text = "";
                    nmrcUdFoodPrice.Value = 0;
                }
                else
                {
                    MessageBox.Show("Please select the food to be updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }

        private void btnFoodDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedFood != null)
                {
                    _db.Foods.Remove(selectedFood);
                    _db.SaveChanges();
                    MessageBox.Show("Deleted.");
                    dgvFoods.DataSource = _db.Foods.ToList();
                    selectedFood = null;
                    txtBoxFoodName.Text = "";
                    nmrcUdFoodPrice.Value = 0;
                }
                else
                {
                    MessageBox.Show("Please select the food to be deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }
    }
}
