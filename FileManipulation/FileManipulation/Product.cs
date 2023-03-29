namespace Exercicios
{
    class Product
    {
        public string Name { get; private set; }
        public double UnitPrice { get; private set; }
        public int Quantity { get; private set; }

        public Product(string name, double unitPrice, int quantity)
        {
            Name = name;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        public double TotalPrice(double unitPrice, int quantity)
        {
            return unitPrice * quantity;
        }
    }
}
