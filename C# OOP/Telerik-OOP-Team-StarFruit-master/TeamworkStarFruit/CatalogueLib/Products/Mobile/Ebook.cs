namespace CatalogueLib.Products
{
    using CatalogueLib.Products.Enumerations;
    using CatalogueLib.Products.Struct;

    public class EBook : Mobile
    {
        public EBook(int ID, decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize, string SupportedFileFormat)
            : base(ID, price, isAvailable, brand, Memory, CPU, RAM, Model, battery, connectivity, ExpandableMemory, ScreenSize)

        {
            this.SupportedFileFormats = SupportedFileFormats;
        }

        public string SupportedFileFormats { get; private set; }

        public override string ToString()
        {
            return base.ToString() + "\nSupported file formats: {this.SupportedFileFormats}";
        }
    }
}
