namespace CatalogueLib.Products
{
    using CatalogueLib.Products.Enumerations;

    public class Desktop : Computer
    {
        public Desktop(int ID, decimal price, bool isAvailable, Brand brand, string CPU, int DriveMemory, string VideoCardModel, string OperationSystem, double ScreenSize, int RAM, bool HasDVDRecorder)
            : base(ID, price, isAvailable, brand, CPU, DriveMemory, VideoCardModel, OperationSystem, ScreenSize, RAM)
        {
            this.HasDVDRecorder = HasDVDRecorder;
        }

        public bool HasDVDRecorder { get; private set; }

        public override string ToString()
        {

            return base.ToString() + "\nHas DVD recorder: {this.HasDVDRecorder}";

        }
    }
}
