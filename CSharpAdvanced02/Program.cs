using System.Globalization;

namespace CSharpAdvanced02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Smart Product Search
            //ProductCatalog productCatalog = new ProductCatalog();
            //List<Product> products = productCatalog.GetProducts();

            //ProductFilterDelegate productFilter = ProductSearch.IsElectronic;
            //List<Product> electronicProducts = ProductSearch.SearchProducts(products, productFilter);
            //Console.WriteLine("--- Electronics ---");
            //PrintProducts(electronicProducts);
            //Console.WriteLine("\n========================================\n");

            //ProductFilterDelegate cheapFilter = ProductSearch.IsCheaper;
            //List<Product> cheapProducts = ProductSearch.SearchProducts(products, cheapFilter);
            //Console.WriteLine("--- Under $50 ---");
            //PrintProducts(cheapProducts);
            //Console.WriteLine("\n========================================\n");

            //ProductFilterDelegate inStockFilter = ProductSearch.IsInStock;
            //List<Product> inStock = ProductSearch.SearchProducts(products, inStockFilter);
            //Console.WriteLine("--- In Stock ---");
            //PrintProducts(inStock);
            //Console.WriteLine("\n========================================\n");

            //ProductFilterDelegate clothingUnder100Filter = ProductSearch.IsCheapClothing;
            //List<Product> clothingUnder100 = ProductSearch.SearchProducts(products, clothingUnder100Filter);
            //Console.WriteLine("--- Clothing Under $100 ---");
            //PrintProducts(clothingUnder100); 
            #endregion

        }
        public static void PrintProducts(List<Product> products)
        {
            foreach(Product product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Price:C} (Stock: {product.Stock})");
            }
        }
    }
}
