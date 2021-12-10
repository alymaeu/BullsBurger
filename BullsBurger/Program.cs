using System;

namespace BullsBurger
{
    class Program
    {
        static void Main(string[] args)
        {
            BullsBurger myRest = new BullsBurger("Bulls Burger", "Tampa", 7.50, 100);
            Console.WriteLine("Welcome to {0} in {1}", myRest.Name, myRest.City);
            myRest.CreateReceipt();
        }
    }
}