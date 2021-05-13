using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class ItemGeneral
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }


        public ItemGeneral(string title, string description, double price)
        {
            Title = title;
            Description = description;
            Price = (decimal)price;
        }
    }
}
