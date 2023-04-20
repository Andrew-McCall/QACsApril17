using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxLambda
{
    public class Product
    {
        public decimal Price { get; init; }
        public string Name { get; init; }
        public Func<decimal, decimal> TaxCalculation { get; init; }
        public string Currency { get; init; } 

        public Product(decimal price, string currency, string name, Func<decimal, decimal> TC)
        {
            this.Price = price;
            this.Currency = currency;
            this.Name = name;
            this.TaxCalculation = TC;
        }

        public decimal GetTax()
        {
            return this.TaxCalculation(this.Price);
        }

        public override string ToString()
        {
            return $"Product=[Name:{this.Name}, Worth:{this.Currency}{this.Price}, Tax:{this.Currency}{GetTax()}]";
        }

    }

}
