using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class ItemParticular : ItemGeneral
    {
        public string Number { get; private set; }
        public Store StockedBy { get; private set; }
        public bool Sold { get; private set; }
        public DateTime? SoldDate { get; private set; }
        public Vendor SoldBy { get; private set; }
        public string Display
        {
            get
            {
                if (Sold)
                {
                    return "Item sold";
                }
                else
                {
                    return string.Format("{0} - {1}", Title, Price);
                }
                
                
            }
        }

        public ItemParticular(string title, string description, double price, string number) : base(title, description, price)
        {
            Number = number;
            Sold = false;
            SoldDate = null;
        }

        public void Sell(Vendor currentVendor)
        {
            if (Sold.Equals(false))
            {
                Sold = true;
                SoldDate = DateTime.Now;
                SoldBy = currentVendor;
            }
            else
            {
                Console.WriteLine($"The item {Number} cannot be sold a second time.");
            }
        }

    }
}
