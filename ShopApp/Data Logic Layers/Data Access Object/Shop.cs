 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Shop
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Address { set; get; }

        public Shop(string name, string address):this()
        {
            Name = name;
            Address = address;
        }

        public Shop()
        {
            
        }
    }
}
