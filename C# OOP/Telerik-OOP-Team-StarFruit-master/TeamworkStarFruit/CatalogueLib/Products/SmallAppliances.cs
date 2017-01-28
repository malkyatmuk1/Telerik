namespace CatalogueLib
{
    using CatalogueLib.Products.Enumerations;
    using System.Text;

    public abstract class SmallAppliances : Product
    {
        public SmallAppliances(int ID, decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes)
            : base(ID, price, isAvailable, brand)
        {
            this.Capacity = Capacity;
            this.CableLength = CableLength;
            this.Affixes = Affixes;
        }

        public double Capacity { get; private set; }

        public double CableLength { get; private set; }

        public int Affixes { get; private set; }

        public override string ToString()
        {
            
            StringBuilder result = new StringBuilder();
            result = result.Append(string.Format("{0}", base.ToString()));
            result = result.Append(string.Format(" Capacity: {0}",this.Capacity));
            result = result.AppendLine();
            result = result.Append(string.Format(" Cable length: {0}",this.CableLength));
            result = result.AppendLine();
            result = result.Append(string.Format(" Affixes: {0}", this.Affixes));
            return result.AppendLine().ToString();
        }
    }
}
