using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopApp.Business_Logic_Layers;

namespace ShopApp
{
    public partial class ShopUI : Form
    {
        public ShopUI()
        {
            InitializeComponent();
        }

        private Shop aShop;
        private ShopBLL aShopBll= new ShopBLL();
        private Item aItem;

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(shopNameTextBox.Text, shopAddressTextBox.Text);
            string msg = aShopBll.Save(aShop);
            MessageBox.Show(msg);
            
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            aItem = new Item(itemIdTextBox.Text, Convert.ToInt16(quantityTextBox.Text));
            string msg = aShopBll.Add(aItem);
            MessageBox.Show(msg);   
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string msg = aShopBll.GetAllItem();
            MessageBox.Show(msg);
        }
    }
}
