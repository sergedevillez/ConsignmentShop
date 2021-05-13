using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        public string Name { get; private set; }
        public List<Vendor> ListVendors { get; private set; }
        public List<ItemParticular> Stock { get; private set; }

        public Store(string name, List<Vendor> listVendors = null, List<ItemParticular> stock = null)
        {
            Name = name;
            if (listVendors != null)
                ListVendors = listVendors;
            else
            {
                ListVendors = new List<Vendor> { };
            }
            if (stock != null)
                Stock = stock;
            else
            {
                Stock = new List<ItemParticular> { };
            }

            
        }

        public void AddOrDeleteVendor(Vendor vendor, bool wishToAdd)
        {
            if (wishToAdd.Equals(true))
            {
                if (!ListVendors.Contains(vendor))
                {
                    ListVendors.Add(vendor);
                }
                else
                {
                    Console.WriteLine($"Impossible to add the vendor {vendor.LastName} {vendor.FirstName} a second time.");
                }
            }
            else
            {
                if (ListVendors.Contains(vendor))
                {
                    ListVendors.Remove(vendor);
                }
                else
                {
                    Console.WriteLine($"Impossible to remove the vendor {vendor.LastName} {vendor.FirstName} while he isn't present.");
                }
            }
        }

        public void AddItemToStock(ItemParticular itemToAdd)
        {
            Stock.Add(itemToAdd);
        }

    }
}
