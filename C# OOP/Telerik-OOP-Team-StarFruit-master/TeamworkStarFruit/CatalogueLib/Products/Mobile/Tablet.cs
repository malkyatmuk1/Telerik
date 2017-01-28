namespace CatalogueLib.Products
{
    using CatalogueLib.Products.Enumerations;
    using CatalogueLib.Products.Struct;

    public class Tablet : Mobile
    {
        public Tablet(int ID, decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize, double FrontCamera, double BackCamera, bool HasGPS)
            : base(ID, price, isAvailable, brand, Memory, CPU, RAM, Model, battery, connectivity, ExpandableMemory, ScreenSize)
        {
            this.FrontCamera = FrontCamera;
            this.BackCamera = BackCamera;
            this.HasGPS = HasGPS;
        }

        public double FrontCamera { get; private set; }

        public double BackCamera { get; private set; }

        public bool HasGPS { get; private set; }

        public override string ToString()
        {
            return base.ToString() + "\nFront camera: {this.FrontCamera} MP\nBack camera: {this.BackCamera} MP\n Tablet has GPS: {this.HasGPS}";
        }
    }
}