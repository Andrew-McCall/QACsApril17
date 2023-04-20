using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagtes
{
    public class Operations
    {
        public static int Add(int a, int b) { return a + b; }
        public int Subtract(int a, int b) { return a - b; }

        public void ShowStrings(string a, string b)
        {
            Console.WriteLine(a + " : " + b);
        }

        public void ShowStringsOnNewLine(string a, string b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
