using LINQ.Data;

namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = Product.GetProducts();
            // public override string ToString();
            Console.WriteLine(products[0].UnitPrice);

        }
    }
}