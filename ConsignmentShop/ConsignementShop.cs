using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ConsignmentShopUI
{
    public partial class ConsignementShop : Form
    {
        private Store store = new Store("First store");
        private List<ItemParticular> shoppingCartData = new List<ItemParticular> ();

        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();

        public ConsignementShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Stock;
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            itemsCartListBox.DataSource = cartBinding;

            itemsCartListBox.DisplayMember = "Display";
            itemsCartListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            store.ListVendors.Add(new Vendor("Bob", "Kertlin", null));
            store.ListVendors.Add(new Vendor("Sue", "Jhon", .1));
            store.ListVendors.Add(new Vendor("Marc", "Dufold", 0.02));

            store.AddItemToStock(new ItemParticular("Harry Potter 1", "The first book of the Harry Potter saga", 5.56, "#000001"));
            store.AddItemToStock(new ItemParticular("Harry Potter 2", "The second book of the Harry Potter saga", 5.00, "#000002"));
            store.AddItemToStock(new ItemParticular("A black shovel", "A shovel colored in black.", 15.99, "#000003"));
        }




        private void AddItemToCart_Click(object sender, EventArgs e)
        {
            ItemParticular currentItemSelected = (ItemParticular)itemsListBox.SelectedItem;
            if (!currentItemSelected.Sold)
            {
                shoppingCartData.Add(currentItemSelected);
                cartBinding.ResetBindings(false);//Pass true if the type of list/class change

                store.Stock.Remove(currentItemSelected);
                itemsBinding.ResetBindings(false);
            }
        }

        private void RemoveFromItemsCart_Click(object sender, EventArgs e)
        {
            ItemParticular currentItemSelected = (ItemParticular)itemsCartListBox.SelectedItem;

            store.Stock.Add(currentItemSelected);
            itemsBinding.ResetBindings(false);

            shoppingCartData.Remove(currentItemSelected);
            cartBinding.ResetBindings(false);

        }

        private void PurchaseCart_Click(object sender, EventArgs e)
        {
            if(shoppingCartData.Count > 0)
            {
                List<ItemParticular> currentCart = shoppingCartData;
                decimal totalPrice = 0;
                foreach(ItemParticular item in currentCart)
                {
                    item.Sell(store.ListVendors[1]);//Hard-coded vendor
                    store.Stock.Add(item);
                    totalPrice += item.Price;
                }

                shoppingCartData.Clear();

                cartBinding.ResetBindings(false);

                
                itemsBinding.ResetBindings(false);

            
                MessageBox.Show("You need to pay " + totalPrice);
            }
            
        }
    }
}
