using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exceptions.Database
{
    public class MyCustomException : Exception
    {
        public bool MinorFault = true;
        public MyCustomException() : base("Custom message is here")
        {

        }

        public MyCustomException(bool minorfualt) : this()
        {
            this.MinorFault = minorfualt;
        }
    }
}
