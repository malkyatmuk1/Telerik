namespace CatalogueTest
{
    using MenuLib;

    public class CatalogueStartUp
    {
        static void Main()
        {
            Menu m = new Menu();
            Menu.CreateMenu();
            Menu.ShowMenu("1");
            m.Navigate();
        }
    }
}
