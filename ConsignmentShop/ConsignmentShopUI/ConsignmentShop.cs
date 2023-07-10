﻿using ConsignmentShopLibrary; //
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
		private Store store = new Store(); //
		private List<Item> shoppingCartData = new List<Item>();
		BindingSource itemsBinding = new BindingSource();
		BindingSource cartBinding = new BindingSource();
		BindingSource vendorsBinding = new BindingSource();
		private decimal storeProfit = 0;
		public ConsignmentShop()
		{
			InitializeComponent();
			SetupData(); //

			itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
			itemsListbox.DataSource = itemsBinding;

			itemsListbox.DisplayMember = "Display";
			itemsListbox.ValueMember = "Display";

			cartBinding.DataSource = shoppingCartData;
			shoppingCartListbox.DataSource = cartBinding;

			shoppingCartListbox.DisplayMember = "Display";
			shoppingCartListbox.ValueMember = "Display";

			vendorsBinding.DataSource = store.Vendors;
			vendorListbox.DataSource = vendorsBinding;

			vendorListbox.DisplayMember = "";
			vendorListbox.ValueMember = "";
		}

		private void SetupData() //
		{
			Vendor demoVendor = new Vendor();
			store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
			store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

			store.Items.Add(new Item {
				Title = "Moby Dick",
				Description = "A book about a whale",
				Price = 4.50M,
				Owner = store.Vendors[0] });

			store.Items.Add(new Item
			{
				Title = "A Tale of Two Cities",
				Description = "A book about a revolution",
				Price = 3.80M,
				Owner = store.Vendors[1]
			});

			store.Items.Add(new Item
			{
				Title = "Harry Potter",
				Description = "A book about a boy",
				Price = 5.20M,
				Owner = store.Vendors[1]
			});

			store.Items.Add(new Item
			{
				Title = "Jane Eyre",
				Description = "A book about a girl",
				Price = 1.50M,
				Owner = store.Vendors[0]
			});

			store.Name = "Seconds are Better";
		}

		private void AddToCart_Click(object sender, EventArgs e)
		{
			Item selectedItem = (Item)itemsListbox.SelectedItem;
			shoppingCartData.Add(selectedItem);
			cartBinding.ResetBindings(false);
		}

		private void makePurchase_Click(object sender, EventArgs e)
		{
			foreach(Item item in shoppingCartData)
			{
				item.Sold = true;
				item.Owner.PaymentDue += (decimal)item.Owner.Comission * item.Price;
				storeProfit += (1 - (decimal)item.Owner.Comission) * item.Price;
			}
			shoppingCartData.Clear();
			itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
			storeProfitValue.Text = string.Format("${0}", storeProfit);
			cartBinding.ResetBindings(false);
			itemsBinding.ResetBindings(false);
			vendorsBinding.ResetBindings(false);
		}
		
	}
}
