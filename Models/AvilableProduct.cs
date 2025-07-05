namespace ECOMMERCESYSTEM.Models{
    public class AvilableProduct : Product, Shipped{
        public double Weight { get;}

        public AvilableProduct(string name, double price, int quantity, double weight)
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