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
    public partial class AddExtraMaterial : Form
    {
        List<Extra> _extras;
        public AddExtraMaterial(List<Extra> extras)
        {
            InitializeComponent();
            _extras = extras;
        }

        private void btnSaveExtraIngredient_Click(object sender, EventArgs e)
        {
            if (txtBoxExtraIngredientName != null && nmrcUdPrice.Value > 0)
            {
                Extra extra = new Extra(txtBoxExtraIngredientName.Text, nmrcUdPrice.Value);
                _extras.Add(extra);
                MessageBox.Show("The extra material is added successfully.");
            }
            else
            {
                MessageBox.Show("Plase enter the ingredient name and/or price!");
            }
        }
    }
}
