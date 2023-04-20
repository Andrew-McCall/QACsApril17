using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagtes
{
    public class Calc
    {
        public Func<int, int, int> currentOperation;

        public int execute(int a, int b)
        {
            return currentOperation(a, b);
        }

        public void screenOutput (Action<string, string> act, string a, string b)
        {
            act(a, b);
        }

    }
}
