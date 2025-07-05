using System;
using ECOMMERCESYSTEM.Entities;
using ECOMMERCESYSTEM.Models;
using ECOMMERCESYSTEM.Services;

namespace ECommerceSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var cheese = new ExpiredProduct("Cheese", 100, 5, DateTime.Now.AddDays(5), 0.2);
            var biscuits = new ExpiredProduct("Biscuits", 150, 2, DateTime.Now.AddDays(2), 0.7);
            var tv = new AvailableProduct("TV", 300, 3, 5);
            var scratchCard = new AvailableProduct("Mobile Scratch Card", 50, 10, 0.1);

            var customer = new Customer("Omar", 500);
            var cart = new Cart();

            cart.AddItem(cheese, 2);
            cart.AddItem(biscuits, 1);
            cart.AddItem(scratchCard, 1);

            var checkout = new CheckoutService();
            checkout.Checkout(customer, cart);

            Console.WriteLine($"Remaining balance: {customer.Balance}");
        }
    }
}
