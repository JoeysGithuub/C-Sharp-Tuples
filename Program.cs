using System;
using System.Collections.Generic;
namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

                (string product, double amount, int quantity) hammer = ("Hammer", 19.99, 25);
                (string product, double amount, int quantity) nails = ("nails", 45.55, 67);
                (string product, double amount, int quantity) nailGun = ("nailGun", 42.87, 88);
                (string product, double amount, int quantity) bandaids = ("Bandaids", 27.89, 99);
                (string product, double amount, int quantity) staples = ("Staples", 74.55, 31);

                transactions.Add(hammer);
                transactions.Add(nails);
                transactions.Add(nailGun);
                transactions.Add(bandaids);
                transactions.Add(staples);


                int TotalProductsSold = 0;
                double TotalRevenue = 0;

                foreach ((string product, double amount, int quantity) t in transactions)
                {
                    TotalProductsSold += t.quantity;
                    TotalRevenue += t.quantity * t.amount;
                }
                System.Console.WriteLine($"We sold {TotalProductsSold} products for a profit of ${TotalRevenue}");
        }
    }
}
