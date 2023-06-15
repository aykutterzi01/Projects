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
    public partial class ChangeExtraMaterialPrice : Form
    {
        List<Extra> _extras;
        public ChangeExtraMaterialPrice(List<Extra> extras)
        {
            InitializeComponent();
            _extras = extras;
        }

        private void ChangeExtraMaterialPrice_Load(object sender, EventArgs e)
        {
            foreach (Extra extra in _extras)
            {
                cmbBoxMaterials.Items.Add(extra.Name.ToString());
            }
        }

        private void cmbBoxMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Extra extra in _extras)
            {
                if (cmbBoxMaterials.SelectedItem.ToString() == extra.Name)
                {
                    lblActualPrice.Text = extra.Price.ToString();
                }
            }
        }

        private void btnSavePrice_Click(object sender, EventArgs e)
        {
            if (cmbBoxMaterials.SelectedItem != null && nmrcUdNewPrice.Value > 0)
            {
                foreach (Extra extra in _extras)
                {
                    if (cmbBoxMaterials.SelectedItem.ToString() == extra.Name)
                    {
                        extra.Price = nmrcUdNewPrice.Value;
                        MessageBox.Show("The price has been updated successfully.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Plase choose the material and/or enter the price!");
            }
        }
    }
}
