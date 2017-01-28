﻿namespace CatalogueLib.Products
{
    using CatalogueLib.Products.Enumerations;

    public class VacuumCleaner : SmallAppliances
    {
        public VacuumCleaner(int ID, decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes, double GarbageBagVolume)
            : base(ID, price, isAvailable, brand, Capacity, CableLength, Affixes)
        {
            this.GarbageBagVolume = GarbageBagVolume;
        }

        // in litres
        public double GarbageBagVolume { get; private set; }

        public override string ToString()
        {
            return base.ToString() + "\nGarbage bag volume: {this.GarbageBagVolume}";
        }
    }
}
