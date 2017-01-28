namespace CatalogueLib
{
    using CatalogueLib.Products.Enumerations;
    using System.Text;

    public abstract class Product
    {
        public decimal Price { get; private set; }
        public bool isAvailable { get; private set; }
        public int Count { get; private set; }
        public Brand brand { get; private set; }
        public int ID { get; private set; }
        public Product(int ID, decimal price, bool isAvailable, Brand brand)
        {
            this.ID = ID;
            this.Price = price;
            this.isAvailable = isAvailable;
            this.brand = brand;
        }

        public override string ToString()
        {
            StringBuilder stroitel = new StringBuilder();
            stroitel = stroitel.Append(string.Format(" Brand: {0}\n Prduct is available: {1}\n Price: {2}", this.brand, this.isAvailable, this.Pricey));
            return stroitel.AppendLine().ToString();
        }
    }
}
