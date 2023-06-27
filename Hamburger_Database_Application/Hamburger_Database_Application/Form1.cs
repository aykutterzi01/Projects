using Hamburger_Database_Application.Context;

namespace Hamburger_Database_Application
{
    public partial class Form1 : Form
    {
        ApplicationDbContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(_db);
            createOrder.MdiParent = Form1.ActiveForm;
            createOrder.Dock = DockStyle.Fill;
            createOrder.Show();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails(_db);
            orderDetails.MdiParent = Form1.ActiveForm;
            orderDetails.Dock = DockStyle.Fill;
            orderDetails.Show();
        }

        private void foodPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodPanel foodPanel = new FoodPanel(_db);
            foodPanel.MdiParent = Form1.ActiveForm;
            foodPanel.Dock = DockStyle.Fill;
            foodPanel.Show();
        }

        private void extraPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtraPanel extraPanel = new ExtraPanel(_db);
            extraPanel.MdiParent = Form1.ActiveForm;
            extraPanel.Dock = DockStyle.Fill;
            extraPanel.Show();
        }
    }
}