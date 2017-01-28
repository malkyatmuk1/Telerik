namespace CatalogueLib
{
    using CatalogueLib.Products.Enumerations;
    using System.Text;

    public abstract class BigAppliances : Product
    {
        public BigAppliances(int ID, decimal price, bool isAvailable, Brand brand, string Color, string CountryOfOrigin)
            : base(ID, price, isAvailable, brand)
        {
            this.Color = Color;
            this.CountryOfOrigin = CountryOfOrigin;
        }

        public string Color { get; private set; }

        public string CountryOfOrigin { get; private set; }

        public override string ToString()
        {
           
            StringBuilder outline = new StringBuilder();
            outline = outline.Append(string.Format("{0}", base.ToString()));
            outline = outline.Append(string.Format(" Color: {0}", this.Color));
            outline = outline.AppendLine();
            outline = outline.Append(string.Format(" Made in: {0}", this.CountryOfOrigin));
            return outline.AppendLine().ToString();
           
        }

    }
}
