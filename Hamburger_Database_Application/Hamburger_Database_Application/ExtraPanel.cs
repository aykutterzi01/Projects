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
    public partial class ExtraPanel : Form
    {
        ApplicationDbContext _db;
        Extra selectedExtra;
        public ExtraPanel(ApplicationDbContext db)
        {
            InitializeComponent();
            _db = db;
            dgvExtras.DataSource = _db.Extras.ToList();
        }

        private void dgvExtras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedExtra = _db.Extras.Find(Convert.ToInt32(dgvExtras.Rows[e.RowIndex].Cells[0].Value));

            txtBoxExtraName.Text = selectedExtra.Name;
            nmrcUdExtraPrice.Value = selectedExtra.Price;
        }

        private void btnExtraAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Extra extra = new Extra();
                extra.Name = txtBoxExtraName.Text;
                extra.Price = nmrcUdExtraPrice.Value;

                _db.Extras.Add(extra);
                _db.SaveChanges();
                MessageBox.Show("Extra is added to the list.");
                dgvExtras.DataSource = _db.Extras.ToList();
                txtBoxExtraName.Text = "";
                nmrcUdExtraPrice.Value = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }

        private void btnExtraUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedExtra != null)
                {
                    selectedExtra.Name = txtBoxExtraName.Text;
                    selectedExtra.Price = nmrcUdExtraPrice.Value;
                    _db.SaveChanges();
                    MessageBox.Show("Updated");
                    dgvExtras.DataSource = _db.Extras.ToList();
                    selectedExtra = null;
                    txtBoxExtraName.Text = "";
                    nmrcUdExtraPrice.Value = 0;

                }
                else
                {
                    MessageBox.Show("Please select the extra to be updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }

        private void btnExtraDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedExtra != null)
                {
                    _db.Extras.Remove(selectedExtra);
                    _db.SaveChanges();
                    MessageBox.Show("Deleted");
                    dgvExtras.DataSource = _db.Extras.ToList();
                    selectedExtra = null;
                    txtBoxExtraName.Text = "";
                    nmrcUdExtraPrice.Value = 0;

                }
                else
                {
                    MessageBox.Show("Please select the extra to be deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata! " + ex.Message);
            }
        }
    }
}
