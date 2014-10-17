using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.Data_Logic_Layers.Getway;

namespace ShopApp.Business_Logic_Layers
{
    
    class ShopBLL
    {
        private ShopGetway aShopGetway;

        public ShopBLL()
        {
            aShopGetway = new ShopGetway();
        }

        public string Save(Shop aShop)
        {
            if (aShop.Name== string.Empty|| aShop.Address== string.Empty)
            {
                return "Please fillup all field.";
            }
            return aShopGetway.Save(aShop);
        }

        public string Add(Item aItem)
        {
            
            if (HasThisItem(aItem.ItemId))
            {
                return UpdateItem(aItem);
            }
            return aShopGetway.Add(aItem);
        }


        public bool HasThisItem(string itemId)
        {
            return aShopGetway.HasThisItem(itemId);
        }

        private string UpdateItem(Item aItem)
        {
            return aShopGetway.UpdateItem(aItem);
        }

        public string GetAllItem()
        {
            return aShopGetway.GetAllItem();
        }
    }
}
