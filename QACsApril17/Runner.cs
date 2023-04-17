using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsLibrary;

namespace QACsApril17
{
    internal class Runner
    {
        public static void Main(String[] args)
        {

            int[] array = new int[0];
            while (true)
            {
                Console.WriteLine("Enter a number or q to quit:");
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue;

                if (input.Equals("q"))
                {
                    break;
                }

                int inputParsed = int.Parse(input);
                
                int[] shoeHornedArray = new int[array.Length + 1];
                int i = 0;
                while (i < array.Length) shoeHornedArray[i] = array[i++];
                shoeHornedArray[shoeHornedArray.Length - 1] = inputParsed;
                
                array = shoeHornedArray;
            }

            decimal sum = 0;
            int index = 0;
            while (index < array.Length)
            {
                sum += array[index++];
            }

            Console.WriteLine(sum / array.Length);

        }

        /// Calculate an average
        // Loop for inputs of numbers, until q
        // after q we print the average
        /// Extention: make is a calc-function


        /// tmr
        // forloops
        // collections
        // foreach/iterators

        enum EyeColor
        {
            // PropertyName and int
            White = 0,
            Green = 1,
            Blue = 2,
            Brown = 3
        }

    }

} 

