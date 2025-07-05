using ECOMMERCESYSTEM.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECOMMERCESYSTEM.Services
{
    public class Shipping
    {
        public static double SHIPPING_FEE_PER_KG = 30;

        public static double ShipItems(List<Shipped> items)
        {
            Console.WriteLine("** Shipment notice **");

            double totalWeight = 0;
            var grouped = items.GroupBy(p => p.GetName());

            foreach (var group in grouped)
            {
                var weight = group.Sum(i => i.GetWeight());
                Console.WriteLine($"{group.Count()}x {group.Key} {weight * 1000:F0}g");
                totalWeight += weight;
            }

            Console.WriteLine($"Total package weight {totalWeight:F2}kg");

            return totalWeight * SHIPPING_FEE_PER_KG;
        }
    }
}
