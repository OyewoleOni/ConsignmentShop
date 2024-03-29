﻿using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListBox.DataSource = itemBinding;
            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListBox.DataSource = cartBinding;
            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorsBinding;
            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            //Vendor demoVendor = new Vendor();

            //demoVendor.FirstName = "";
            //demoVendor.LastName = "";
            //demoVendor.Commission = .5;

            //store.Vendors.Add(demoVendor);

            //demoVendor = new Vendor();

            //demoVendor.FirstName = "";
            //demoVendor.LastName = "";
            //demoVendor.Commission = .5;

            //store.Vendors.Add(demoVendor);

            //Initializse vendors
            store.Vendors.Add(new Vendor { FirstName = "Test1", LastName = "Test1" });
            store.Vendors.Add(new Vendor { FirstName = "Test2", LastName = "Test2" });
            store.Vendors.Add(new Vendor { FirstName = "Test3", LastName = "Test3" });

            //Initialize Items
            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "A tale of Two Cities",
                Description = "A book about Revolution",
                Price = 4.80M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Porter Book 1",
                Description = "A book about boy",
                Price = 5.20M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "A book about birl",
                Price = 1.50M,
                Owner = store.Vendors[0]
            });

            store.Name = "Seconds are better";
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //Figure out what is selected from the items list
            // Copy that item to the shopping cart
            // Do we remove the item from the items list? - no

            Item selectedItem = itemsListBox.SelectedItem as Item;
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(true);
        }

        private void btnMakePurchase_Click(object sender, EventArgs e)
        {
            //Mark each Item as sold
            //Clear the cart

            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            shoppingCartData.Clear();
            itemBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            lblStoreProfitValue.Text = string.Format($"${storeProfit}");

            cartBinding.ResetBindings(false);
            itemBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }
    }
}
