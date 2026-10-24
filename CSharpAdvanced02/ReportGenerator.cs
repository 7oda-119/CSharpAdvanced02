namespace CSharpAdvanced02;

public class ReportGenerator
{
    public static void PrintShortReport(Product product)
        => Console.WriteLine($"{product.Name} - {product.Price:C}");
    public static void PrintLongReport(Product product)
        => Console.WriteLine($"[{product.Category}] {product.Name} | Price: {product.Price:C} | Stock: {product.Stock}");

    public static void GenerateReport(List<Product> products, Action<Product> reportAction)
    {
        if (products is null || products.Count == 0)
            return;

        foreach (Product product in products)
            reportAction.Invoke(product);
    }
}
