namespace CatalogueLib
{
    using System.Collections.Generic;

    public interface ISortable
    {
        IEnumerable<Product> ShowBigAppliances();

        IEnumerable<Product> ShowSmallAppliances();

        IEnumerable<Product> ShowMobiles();

        IEnumerable<Product> ShowComputers();
        
        IEnumerable<Product> ShowAll();
    }
}
