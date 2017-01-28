namespace CatalogueLib.Products
{

    using CatalogueLib.Products.Enumerations;

    public class Laptop : Computer
    {
        public Laptop(int ID, decimal price, bool isAvailable, Brand brand, string CPU, int DriveMemory, string VideoCardModel, string OperationSystem, double ScreenSize, int RAM, int HowManyUSBPorts)
            : base(ID, price, isAvailable, brand, CPU, DriveMemory, VideoCardModel, OperationSystem, ScreenSize, RAM)
        {
            this.HowManyUSBPorts = HowManyUSBPorts;
        }
        public int HowManyUSBPorts { get; private set; }

        public override string ToString()
        {
                return base.ToString() + "\nNumber of USB ports: {this.HowManyUSBPorts}";
        }
    }
}
