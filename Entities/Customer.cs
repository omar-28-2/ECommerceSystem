namespace ECOMMERCESYSTEM.Entities{
    public class Customer{
        public string Name { get; set; }
        public double Balance { get; set; }

        public Customer(string name, double balance){
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty", nameof(name));
            if (balance < 0)
                throw new ArgumentException("Balance cannot be negative", nameof(balance));
                
            Name = name;
            Balance = balance;
        }
    }
}