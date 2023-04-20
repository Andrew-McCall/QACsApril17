using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxLambda
{
    static class TaxCodes
    {

        public static decimal UKTax(decimal price)
        {
            return price * .20M;
        }

        public static decimal USTax(decimal price)
        {
            return price * .01M;
        }

    }
}
