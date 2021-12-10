using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsBurger
{
    class BullsBurger
    {
        private string name;
        private string city;
        private double deliveryfee;
        private double rewardspoints;

        public string Name { get; set; }
        public string City { get; set; }
        public double DeliveryFee
        {
            get
            {
                return deliveryfee;
            }
            set
            {
                if (value >= 0)
                {
                    deliveryfee = value;
                }
            }
        }
        public double RewardsPoints
        {
            get
            {
                return rewardspoints;
            }
            set
            {
                if (value >= 0)
                {
                    rewardspoints = value;
                }
            }
        }
        public BullsBurger(string name, string city, double deliveryfee, double rewardspoints)
        {
            Name = name;
            City = city;
            DeliveryFee = deliveryfee;
            RewardsPoints = rewardspoints;
        }
        public void CreateReceipt()
        {
            double subtotal = 0;
            double discount = 0;
            double price_num = 0;
            double taxrate = 0;
            double taxamount = 0;
            double grandtotal = 0;
            string price_str = "0";

            while (price_str != "Done")
            {
                price_num = Convert.ToDouble(price_str);
                subtotal = subtotal + price_num;
                Console.WriteLine("Enter the price of the next food item (enter \"Done\" to quit):");
                price_str = Console.ReadLine();
            }
            switch (City)
            {
                case "Tampa":
                    Console.WriteLine("Tampa tax rate is 10%");
                    taxrate = .10;
                    break;
                case "Sarasota":
                    Console.WriteLine("Sarasota tax rate is 6%");
                    taxrate = .06;
                    break;
                case "St. Pete":
                    Console.WriteLine("St. Pete tax rate is 8%");
                    taxrate = .08;
                    break;
                default:
                    Console.WriteLine("Unknown city, default Florida tax rate applied at 7%");
                    taxrate = .07;
                    break;
            }
            //discount for rewards
            if (rewardspoints >= 100 && subtotal >= 20.00)
            {
                discount = 5;
                rewardspoints = rewardspoints - 100;
            }
            else
            {
                discount = 0;
            }

            taxamount = subtotal * taxrate;
            grandtotal = subtotal + deliveryfee + taxamount - discount; //minusdiscount

            Console.WriteLine("\n");
            Console.WriteLine("Subtotal: {0:C}", subtotal);
            Console.WriteLine("Discount Applied: {0:C}", discount);
            Console.WriteLine("Delivery Fee: {0:C}", deliveryfee);
            Console.WriteLine("{0:P} tax: {1:C}", taxrate, taxamount);
            Console.WriteLine("Grand Total: {0:C}", grandtotal);
            Console.WriteLine("Rewards Points: {0}", rewardspoints);
        }
    }
}