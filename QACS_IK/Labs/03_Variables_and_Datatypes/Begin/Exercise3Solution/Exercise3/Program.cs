using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(24);
        }

    }
    class Solution
    {
        public void solution(int N)
        {
            for (int i = 1; i <= N; i++)
            {

                String output = "";

                if (i % 2 == 0)
                {
                    output += "Codility";
                }

                if (i % 3 == 0)
                {
                    output += "Test";
                }

                if (i % 5 == 0)
                {
                    output += "Coders";
                }

                if (output.Length == 0)
                {
                    output = N.ToString();
                }

                Console.WriteLine(output);

            }
        }
    }

}
