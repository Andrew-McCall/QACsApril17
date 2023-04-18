using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACsApril17
{
    internal class Calculator2
    {
        private IMathsFunction<double>[] functions;
        public IMathsFunction<double> CurrentOperation;
        public List<string> log = new List<string>();

        public double Use(double a, double b)
        {
            // down casting

           double result =CurrentOperation.Execute(a, b);

            log.Add($"{a} {b} {CurrentOperation.GetType()} {result}");

            return result;
        }
        public void ShowHistory()
        {
            foreach (string s in log)
            {
                Console.WriteLine(s);
            }
        }

        // Changes currentoperation form list and gives opens/ui
        public void ChangeFunction()
        {
            // show each function and index
            // read index inputed
            // change currentoperation to functions[input]
        }
    }

    internal interface IMathsFunction<T>
    { 
        public T Execute(T a, T b);
    }

    internal class Addition : IMathsFunction<double>
    {
        public double Execute(double a, double b)
        {
            return a + b;
        }
    }

    internal class Muliplication : IMathsFunction<int>
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
    internal class Subtraction : IMathsFunction<int>
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
    internal class Divsion : IMathsFunction<double>
    {
        public double Execute(double a, double b)
        {
            return a / b;
        }
    }
}
