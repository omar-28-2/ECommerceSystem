using ECOMMERCESYSTEM.Models;
using ECOMMERCESYSTEM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECOMMERCESYSTEM.Services
{
    public class CheckoutService
    {
        public void Checkout(Customer customer, Cart cart)
        {
            if (cart.IsEmpty())
                throw new Exception("Cart is empty.");

            double subtotal = 0;
            List<Shipped> shippables = new List<Shipped>();

            foreach (var item in cart.Items)
            {
                Product product = item.Key;
                int quantity = item.Value;

                if (product.Quantity < quantity)
                    throw new Exception($"Not enough stock for {product.Name}");

                if (product.IsExpired())
                    throw new Exception($"{product.Name} is expired.");

                subtotal += product.Price * quantity;
                product.Quantity -= quantity;

                if (product is Shipped)
                {
                    for (int i = 0; i < quantity; i++)
                        shippables.Add((Shipped)product);
                }
            }

            double shippingFee = shippables.Count > 0 ? Shipping.ShipItems(shippables) : 0;
            double total = subtotal + shippingFee;

            if (customer.Balance < total)
                throw new Exception("Insufficient balance.");

            customer.Balance -= total;

            Console.WriteLine("** Checkout receipt **");
            foreach (var item in cart.Items)
                Console.WriteLine($"{item.Value}x {item.Key.Name,-20} ${item.Key.Price * item.Value,8:F2}");

            Console.WriteLine("----------------------");
            Console.WriteLine($"Subtotal:              ${subtotal,8:F2}");
            Console.WriteLine($"Shipping:              ${shippingFee,8:F2}");
            Console.WriteLine($"Total:                 ${total,8:F2}");

            cart.Clear();
        }
    }
}
