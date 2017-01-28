namespace CatalogueLib
{
    using CatalogueLib.Products.Enumerations;
    using System.Text;

    public abstract class Computer : Product
    {
        public Computer(int ID, decimal price, bool isAvailable, Brand brand, string CPU, int DriveMemory, string VideoCardModel, string OperationSystem, double ScreenSize, int RAM)
            : base(ID, price, isAvailable, brand)
        {
            this.CPU = CPU;
            this.DriveMemory = DriveMemory;
            this.VideoCardModel = VideoCardModel;
            this.OperationSystem = OperationSystem;
            this.ScreenSize = ScreenSize;
            this.RAM = RAM;
        }

        public string CPU { get; private set; }

        //in megabytes
        public int DriveMemory { get; private set; }

        public string VideoCardModel { get; private set; }

        public string OperationSystem { get; private set; }

        //in inches
        public double ScreenSize { get; private set; }

        //in gigs
        public int RAM { get; private set; }

        public override string ToString()
        {
           
            StringBuilder outline = new StringBuilder();
            outline = outline.Append(string.Format("{0}", base.ToString()));
            outline = outline.Append(string.Format(" CPU: {0}", this.CPU));
            outline = outline.AppendLine();
            outline = outline.Append(string.Format(" Drive Memory: {0} megabytes", this.DriveMemory));
            outline = outline.AppendLine();
            outline = outline.Append(string.Format(" Video Card: {0}", this.VideoCardModel));
            outline = outline.AppendLine();
            outline = outline.Append(string.Format(" Operation System: {0}", this.OperationSystem));
            outline = outline.AppendLine();
            outline = outline.Append(string.Format(" Screen size: {0} inches", this.ScreenSize));
            outline = outline.AppendLine();
            outline = outline.Append(string.Format(" RAM: {0}", this.RAM));
            return outline.AppendLine().ToString();
            
        }

    }
}
