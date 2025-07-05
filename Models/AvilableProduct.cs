namespace ECOMMERCESYSTEM.Models{
    public class AvailableProduct : Product, Shipped{
        public double Weight { get;}

        public AvailableProduct(string name, double price, int quantity, double weight)
        : base(name, price, quantity)
        {
            Weight = weight;
        }

        public override bool IsExpired(){
            return false;
        }

        public string GetName() {
            return Name;
        }
        public double GetWeight() {
            return Weight;
        }
    }
}