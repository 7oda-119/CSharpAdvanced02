namespace CSharpAdvanced02;

public delegate bool ProductFilterDelegate(Product product);
public class ProductSearch
{
    public static bool IsElectronic(Product product) => product.Category == "Electronics";
    public static bool IsCheaper(Product product) => product.Price < 50;
    public static bool IsInStock(Product product) => product.Stock > 0;
    public static bool IsCheapClothing(Product product) => product.Category == "Clothing" && product.Price < 100;

    public static List<Product> SearchProducts(List<Product> products, ProductFilterDelegate productFilter)
    {
        List<Product> result = new List<Product>();
        if (products is not null && products.Count > 0 )
        {
            foreach (Product product in products)
            {
                if (productFilter.Invoke(product))
                    result.Add(product);
            }
            return result;
        }
        return default!;
    }

}
