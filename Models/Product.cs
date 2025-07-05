namespace ECOMMERCESYSTEM.Models{
    public abstract class Product{
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity){
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty", nameof(name));
            if (price < 0)
                throw new ArgumentException("Price cannot be negative", nameof(price));
            if (quantity < 0)
                throw new ArgumentException("Quantity cannot be negative", nameof(quantity));
                
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public abstract bool IsExpired();
    }
}