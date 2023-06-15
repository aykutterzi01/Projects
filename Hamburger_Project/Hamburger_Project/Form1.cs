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
    public partial class Form1 : Form
    {

        List<Menus> menus;
        List<Extra> extras;
        List<Order> allOrders;


        public Form1()
        {
            InitializeComponent();
            menus = new List<Menus>();
            extras = new List<Extra>();
            allOrders = new List<Order>();
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(menus, extras, allOrders);
            createOrder.MdiParent = Form1.ActiveForm;
            createOrder.Dock = DockStyle.Fill;
            createOrder.Show();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails(allOrders);
            orderDetails.MdiParent = Form1.ActiveForm;
            orderDetails.Dock = DockStyle.Fill;
            orderDetails.Show();
        }

        private void addMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMenu addMenu = new AddMenu(menus);
            addMenu.MdiParent = Form1.ActiveForm;
            addMenu.Dock = DockStyle.Fill;
            addMenu.Show();
        }

        private void addExtraMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExtraMaterial addExtraMaterial = new AddExtraMaterial(extras);
            addExtraMaterial.MdiParent = Form1.ActiveForm;
            addExtraMaterial.Dock = DockStyle.Fill;
            addExtraMaterial.Show();
        }

        private void changeMenuPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeMenuPrice changeMenuPrice = new ChangeMenuPrice(menus);
            changeMenuPrice.MdiParent = Form1.ActiveForm;
            changeMenuPrice.Dock = DockStyle.Fill;
            changeMenuPrice.Show();
        }

        private void changeExtraMaterialPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeExtraMaterialPrice changeExtraMaterialPrice = new ChangeExtraMaterialPrice(extras);
            changeExtraMaterialPrice.MdiParent = Form1.ActiveForm;
            changeExtraMaterialPrice.Dock = DockStyle.Fill;
            changeExtraMaterialPrice.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Menus menu1 = new Menus("Big King Menu", 75m);
            menus.Add(menu1);

            Menus menu2 = new Menus("Double King Chicken Menu", 100);
            menus.Add(menu2);

            Menus menu3 = new Menus("Steakhouse Menu", 125);
            menus.Add(menu3);

            Menus menu4 = new Menus("Whooper Menu", 90);
            menus.Add(menu4);

            Menus menu5 = new Menus("Whooper Jr. Menu", 80);
            menus.Add(menu5);

            Menus menu6 = new Menus("Chicken Royal Menu", 130);
            menus.Add(menu6);

            Extra extra1 = new Extra("Ketchup", 1);
            extras.Add(extra1);

            Extra extra2 = new Extra("Mayonnaise", 2);
            extras.Add(extra2);

            Extra extra3 = new Extra("Mustard", 3);
            extras.Add(extra3);

            Extra extra4 = new Extra("BBQ", 4);
            extras.Add(extra4);

            Extra extra5 = new Extra("Ranch", 5);
            extras.Add(extra5);

            Extra extra6 = new Extra("Buffalo", 6);
            extras.Add(extra6);

        }


    }
}
