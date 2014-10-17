using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Item
    {

        public int Id { set; get; }
        public string ItemId { get; set; }
        public int Quantity { set; get; }

        public Item(string itemId, int quantity)
        {
            ItemId = itemId;
            Quantity = quantity;
        }


    }
}
