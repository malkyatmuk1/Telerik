namespace FactoryLib
{
    using FactoryLib.Utilities;
    using CatalogueLib.Products;
    using CatalogueLib.Products.Enumerations;
    using CatalogueLib.Products.Struct;

    public class Factory : IMobileFactory, IBigAppliancesFactory, IComputerFactory, ISmallAppliancesFactory
    {
        private readonly IDGenerator generator;
        public Factory(IDGenerator generator)
        {
            this.generator = generator;
        }

        public AirConditioner CreateAirConditioner(decimal price, bool isAvailable, Brand brand, string Color, string CountryOfBirth, string TypeOfSystem, bool HasWiFi)
        {
            return new AirConditioner(this.generator.GenerateID(), price, isAvailable, brand, Color, CountryOfBirth, TypeOfSystem, HasWiFi);
        }

        public Desktop CreateDesktop(decimal price, bool isAvailable, Brand brand, string CPU, int DriveMemory, string VideoCardModel, string operationSystem, double ScreenSize, int RAM, bool HasDVDRecorder)
        {
            return new Desktop(this.generator.GenerateID(), price, isAvailable, brand, CPU, DriveMemory, VideoCardModel, operationSystem, ScreenSize, RAM, HasDVDRecorder);
        }

        public EBook CreateEbook(decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize, string SupportedFileFormat)
        {
            return new EBook(this.generator.GenerateID(), price, isAvailable, brand, Memory, CPU, RAM, Model, battery, connectivity, ExpandableMemory, ScreenSize, SupportedFileFormat);
        }

        public HairDryer CreateHairDryer(decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes, int DifferentSpeeds)
        {
            return new HairDryer(this.generator.GenerateID(), price, isAvailable, brand, Capacity, CableLength, Affixes, DifferentSpeeds);
        }

        public Laptop CreateLaptop(decimal price, bool isAvailable, Brand brand, string CPU, int DriveMemory, string VideoCardModel, string OperationSystem, double ScreenSize, int RAM, int HowManyUSBPorts)
        {
            return new Laptop(this.generator.GenerateID(), price, isAvailable, brand, CPU, DriveMemory, VideoCardModel, OperationSystem, ScreenSize, RAM, HowManyUSBPorts);
        }

        public Mixer CreateMixer(decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes, bool HasBowl)
        {
            return new Mixer(this.generator.GenerateID(), price, isAvailable, brand, Capacity, CableLength, Affixes, HasBowl);
        }

        public MobilePhone CreateMobilePhone(decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize, string GPU, string OperatingSystem)
        {
            return new MobilePhone(this.generator.GenerateID(), price, isAvailable, brand, Memory, CPU, RAM, Model, battery, connectivity, ExpandableMemory, ScreenSize, GPU, OperatingSystem);
        }

        public Oven CreateOven(decimal price, bool isAvailable, Brand brand, string Color, string CountryOfBirth, string ElectricOrGas)
        {
            return new Oven(this.generator.GenerateID(), price, isAvailable, brand, Color, CountryOfBirth, ElectricOrGas);
        }

        public Refrigerator CreateRefrigerator(decimal price, bool isAvailable, Brand brand, string Color, string CountryOfBirth, string TypeOfTechnology)
        {
            return new Refrigerator(this.generator.GenerateID(), price, isAvailable, brand, Color, CountryOfBirth, TypeOfTechnology);
        }

        public SmartWatch CreateSmartWatch(decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize, double Size, bool WaterResistance)
        {
            return new SmartWatch(this.generator.GenerateID(), price, isAvailable, brand, Memory, CPU, RAM, Model, battery, connectivity, ExpandableMemory, ScreenSize, Size, WaterResistance);
        }

        public Tablet CreateTablet(decimal price, bool isAvailable, Brand brand, int Memory, string CPU, int RAM, string Model, Battery battery, string connectivity, bool ExpandableMemory, double ScreenSize, double FrontCamera, double BackCamera, bool HasGPS)
        {
            return new Tablet(this.generator.GenerateID(), price, isAvailable, brand, Memory, CPU, RAM, Model, battery, connectivity, ExpandableMemory, ScreenSize, FrontCamera, BackCamera, HasGPS);
        }

        public VacuumCleaner CreateVacuumCleaner(decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes, double GarbageBagVolume)
        {
            return new VacuumCleaner(this.generator.GenerateID(), price, isAvailable, brand, Capacity, CableLength, Affixes, GarbageBagVolume);
        }

        public WashingMachine CreateWashingMachine(decimal price, bool isAvailable, Brand brand, string Color, string CountryOfBirth, string LaundryCapacity, string MotorType)
        {
            return new WashingMachine(this.generator.GenerateID(), price, isAvailable, brand, Color, CountryOfBirth, LaundryCapacity, MotorType);
        }
    }
}
