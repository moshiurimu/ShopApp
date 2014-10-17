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
        public string ItenId { get; set; }
        public int Quantity { set; get; }

        public Item(string itenId, int quantity)
        {
            ItenId = itenId;
            Quantity = quantity;
        }


    }
}
