using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagtes
{
    internal class ListKeeper
    {

        public List<int> ints = new List<int>();

        public int? Search (Func<int, bool> act) {

            foreach(int i in ints)
            {
                if (act(i))
                {
                    return i;
                }
            }

            return null;
        }

        public void map(Func<int, int> act)
        {

            for (int i = 0; i < ints.Count; i++)
            {
                ints[i] = act(ints[i]);
            }
        }

        public void forEachAction(Action<int> act)
        {
            foreach (int i in ints)
            {
                act(i);
            }
        }

    }
}
