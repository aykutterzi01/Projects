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
    public partial class ChangeMenuPrice : Form
    {
        List<Menus> _menus;
        public ChangeMenuPrice(List<Menus> menus)
        {
            InitializeComponent();
            _menus = menus;
        }

        private void ChangeMenuPrice_Load(object sender, EventArgs e)
        {
            foreach (Menus menu in _menus)
            {
                cmbBoxMenuPriceChange.Items.Add(menu.Name);
            }

        }

        private void btnSavePrice_Click(object sender, EventArgs e)
        {
            if (cmbBoxMenuPriceChange.SelectedItem != null && nmrcUdNewPrice.Value > 0)
            {
                foreach (Menus menu in _menus)
                {
                    if (cmbBoxMenuPriceChange.SelectedItem.ToString() == menu.Name)
                    {
                        menu.Price = nmrcUdNewPrice.Value;
                        MessageBox.Show("The price has been updated successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose a menu and/or enter a price.");
            }
        }

        private void cmbBoxMenuPriceChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Menus menu in _menus)
            {
                if (cmbBoxMenuPriceChange.SelectedItem.ToString() == menu.Name)
                {
                    lblActualPrice.Text = menu.Price.ToString();
                }
            }
        }
    }
}
