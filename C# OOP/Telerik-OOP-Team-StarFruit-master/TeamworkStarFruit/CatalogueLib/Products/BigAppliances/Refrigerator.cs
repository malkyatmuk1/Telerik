namespace CatalogueLib.Products
{

    using CatalogueLib.Products.Enumerations;

    public class Refrigerator : BigAppliances
    {
        public Refrigerator(int ID, decimal price, bool isAvailable, Brand brand, string Color, string CountryOfBirth, string TypeOfTechnology)
            : base(ID, price, isAvailable, brand, Color, CountryOfBirth)
        {
            this.TypeOfTechnology = TypeOfTechnology;
        }

        public string TypeOfTechnology { get; private set; }

        public override string ToString()
        {
                return base.ToString() + "\nType of coolong system: {this.TypeOfTechnology}";
        }
    }
}