namespace TaxLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>() { new(10M, "£", "Mouse", TaxCodes.UKTax), new(16M, "£", "Headset", TaxCodes.UKTax), new(15M, "$", "Mouse (US)", TaxCodes.USTax), new(10M, "£", "Charity Donation", (price) => price * .05M) };

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("LINQ:");

            //IEnumerable<Product> query1 = from p in products where p.Name == "Mouse" select p;
            IEnumerable<Product> query1 = products.Where(p => p.Name == "Mouse");

            foreach (var p in query1)
            {
                Console.WriteLine(p);
            }

            //var query2 = from p in products where p.GetTax() > .2M orderby p.Price select new {Name=p.Name, Price=p.Price}; 
            var query2 = products.Where(p => p.GetTax() > .2M).OrderBy(p => p.Price).Select(p => new { p.Name, p.Price }); //.Average(p=> p.Price); - returns the answer            // .ToArray(); Will be executed here
            
            foreach (var p in query2)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Cahnge:");

            products.Add(new(20M, "£", "Keyboard", TaxCodes.UKTax));
            foreach (var p in query2)
            {
                Console.WriteLine(p);
            }
        }

    }
}