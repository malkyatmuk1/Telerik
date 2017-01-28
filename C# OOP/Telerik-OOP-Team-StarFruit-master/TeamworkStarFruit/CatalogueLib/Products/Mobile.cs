namespace CatalogueLib
{
    using CatalogueLib.Products.Enumerations;
    using CatalogueLib.Products.Struct;
    using System.Text;

    public abstract class Mobile : Product
    {
        public Mobile(int ID, decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize)
            : base(ID, price, isAvailable, brand)
        {
            this.Memory = Memory;
            this.CPU = CPU;
            this.RAM = RAM;
            this.Model = Model;
            this.battery = battery;
            this.Connectivity = Connectivity;
            this.ExpandableMemory = ExpandableMemory;
            this.ScreenSize = ScreenSize;
        }

        public int Memory { get; private set; }

        public string CPU { get; private set; }

        public int RAM { get; private set; }

        public string Model { get; private set; }

        public Battery battery { get; private set; }

        public string Connectivity { get; private set; }

        public bool ExpandableMemory { get; private set; }

        public double ScreenSize { get; private set; }

        public override string ToString()
        {
            StringBuilder outline = new StringBuilder();
            outline = outline.Append(string.Format("{0}", base.ToString()));
            outline = outline.Append(string.Format(" Model: {0}",this.Model));
            outline = outline.AppendLine();
            outline = outline.Append(string.Format(" Screen size: {0}",this.ScreenSize));
            outline = outline.AppendLine();
            outline = outline.Append(string.Format(" Memory: {0}",this.Memory));
            outline = outline.AppendLine();
            outline = outline.Append(string.Format(" CPU: {0}",this.CPU));
            outline = outline.AppendLine();
            outline = outline.Append(string.Format(" RAM: {0}",this.RAM));
            outline = outline.AppendLine();
            outline = outline.Append(string.Format(" Expandable memory: {0}",this.Memory));
            outline = outline.AppendLine();
            outline = outline.Append(string.Format(" Battery: {0}",this.battery));
            return outline.AppendLine().ToString();
        }

    }
}

