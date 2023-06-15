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
    public partial class AddMenu : Form
    {
        List<Menus> _menus;
        public AddMenu(List<Menus> menus)
        {
            InitializeComponent();
            _menus = menus;
        }

        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            if(txtBoxMenuName != null && nmrcUdPrice.Value > 0)
            {
                Menus menu = new Menus(txtBoxMenuName.Text, nmrcUdPrice.Value);
                _menus.Add(menu);
                MessageBox.Show("New menu is successfully added.");

            }
            else
            {
                MessageBox.Show("Please enter the menu name and/or price");
            }

        }
    }
}
