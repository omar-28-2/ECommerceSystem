namespace ECOMMERCESYSTEM.Models{
    public class ExpiredProduct : Product, Shipped{
        public DateTime ExpirationDate { get;}
        public double Weight { get;}

        public ExpiredProduct(string name, double price, int quantity, DateTime expirationDate, double weight) 
        : base(name, price, quantity)
        {
            ExpirationDate = expirationDate;
            Weight = weight;
        }

        public override bool IsExpired(){ // check if the product is expired
            return DateTime.Now > ExpirationDate;
        }

        public string GetName() {
            return Name;
        }
        public double GetWeight() {
            return Weight;
        }
    }
}