using ECOMMERCESYSTEM.Models;
using System.Collections.Generic;

namespace ECOMMERCESYSTEM.Services
{
    public class Cart
    {
        public Dictionary<Product, int> Items { get; set; }

        public Cart()
        {
            Items = new Dictionary<Product, int>();
        }

        public void AddItem(Product product, int quantity)
        {
            if (quantity > product.Quantity)
            {
                throw new Exception($"Only {product.Quantity} units of {product.Name} are available.");
            }
            if (Items.ContainsKey(product))
            {
                Items[product] += quantity;
            }
            else
            {
                Items[product] = quantity;
            }
        }

        public bool IsEmpty()
        {
            return Items.Count == 0;
        }

        public void Clear()
        {
            Items.Clear();
        }
    }
}