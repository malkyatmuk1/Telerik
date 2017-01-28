namespace CatalogueLib.Products
{
    using CatalogueLib.Products.Enumerations;

    public class Mixer : SmallAppliances
    {
        public Mixer(int ID, decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes, bool HasBowl)
            : base(ID, price, isAvailable, brand, Capacity, CableLength, Affixes)
        {
            this.HasBowl = HasBowl;
        }

        public bool HasBowl { get; private set; }

        public override string ToString()
        {
            return base.ToString() + "\nHas a bowl: {this.HasBowl}";
        }
    }
}
