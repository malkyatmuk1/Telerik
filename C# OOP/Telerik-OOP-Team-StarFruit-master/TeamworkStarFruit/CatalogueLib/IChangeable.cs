namespace CatalogueLib
{
    public interface IChangeable
    {
        void AddProduct(Product product);
        void RemoveProduct(int id);
        void RemoveAll();
    }
}
