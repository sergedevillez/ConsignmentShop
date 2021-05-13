using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double Commission { get; private set; }


        public Vendor(string firstName, string lastName, double? commission)
        {
            FirstName = firstName;
            LastName = lastName;
            if (commission != null)
                Commission = (double)commission;
            else
                Commission = 0.01;
        }

        public void ChangeCommission(double change)
        {
            if ((Commission - Math.Abs(change)) < 0 && change < 0)
            {
                Console.WriteLine($"Impossible to give a negative commission ({(Commission + change)}).");
            }
            else
                Commission += change;

            Console.WriteLine($"{LastName} {FirstName}'s commission was changed to {Commission}.");
        }



        public void SellItem(ItemParticular itemSold)
        {
            itemSold.Sell(this);
        }

    }
}
