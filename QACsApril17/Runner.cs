using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using MathsLibrary;

namespace QACsApril17
{
    internal class Runner
    {
        public static void Main(String[] args)
        {
            // Upcast from dog to animal
            Animal a = new Dog("segeg", "science");
            a.Mph = 10;
            Console.WriteLine(a.Mph);
            Console.WriteLine(a.Kilmetors);

            a.Kilmetors = 10;
            Console.WriteLine(a.Mph);
            Console.WriteLine(a.Kilmetors);


            Console.WriteLine(a.scientifcName);

            //a.age = 10;
            a.SetAge(22);

            Console.WriteLine(a.age);

            if (a is Mammal)
            {
                ((Mammal)a).growHair();
            }

            if (a is IPetable)
            { // Down cast from animal to dog
                ((IPetable)a).Pet();
                
            }

            if (a is Dog)
            {
                ((Dog)a).Pet("head");
            }



            // Class MathsFunction
            // + - / * (% log) as Mathsfunction Subclasses

            // No static methods in the calcualtor
            // MathsFunction is by assocation - Currect operation, Run operation method

            // Extention Array of mathsfunctions
            // Menu
            // list that records operations

            Calculator2 calculator = new Calculator2();
            calculator.CurrentOperation = new Divsion();
            Console.WriteLine(calculator.Use(523, 632));

            calculator.CurrentOperation = new Addition();
            Console.WriteLine(calculator.Use(523, 632));

            calculator.ShowHistory();

            Driver d = new Driver();
            d.vehicle = new Car("Larry");

            Car.Describe();
            d.vehicle.Drive(42);

            // Error -  Car.Drive(5432);
            // Error -  d.vehicle.Describe();
            
            // Arrays (TS)
            // ArrayLists
            // List (TS)

            int[][] array2DIrregular = new int[8][]; 
            int[,]  array2DRegular = new int[8,5]; 

            IList<List<int>> list2D = new List<List<int>>();

            ArrayList al = new ArrayList();
            al.Add(new List<int>());
            al.Add(532);
            al.Add("string");
            al.Add(true);


            // Not type safe - No type needed
            // ArrayList array = new ArrayList();


            List<int> forLoopDemo = new List<int>();
            forLoopDemo.Add(0);
            forLoopDemo.Add(1); 
            forLoopDemo.Add(2);
            forLoopDemo.Add(3);
            forLoopDemo.Add(4);

            Console.WriteLine("forEach");

            foreach (int x in forLoopDemo)
            {
                // x is readonly
                Console.WriteLine(x);
                // x += 53253;
            }

            //  starting      condition          operation
            for (int x = 0; x < forLoopDemo.Count; x++)
            {
                Console.WriteLine(forLoopDemo[x]);
            }

            string[] muppetArray = { "Kermit", "Miss Piggy", "Animal", "Beaker", "Dr Zoot", "Muzzy", "Big Bird" };
            List<string> muppets1 = muppetArray.ToList<string>();
            List<string> muppets2 = new List<string>(muppetArray);
            List<string> muppets3 = new List<string>() { "Kermit", "Miss Piggy", "Animal", "Beaker", "Dr Zoot", "Muzzy", "Big Bird" };

            Console.WriteLine(muppets1[muppets1.Count - 1]);
            Console.WriteLine(muppets1[^1]);


            Console.WriteLine(muppets1[muppets1.Count - 2]);
            Console.WriteLine(muppets1[^2]);

            Dictionary<string, string> catchPhrases = new Dictionary<string, string>();
            catchPhrases.Add("Kermit", "Hi ho!");
            catchPhrases.Add("Piggy", "Hieeeeea!");
            catchPhrases.Add("Beaker", "Meep Meep!");
            Console.WriteLine(catchPhrases["Kermit"]);
            catchPhrases["Kermit"] = "changed!";
            foreach (string key in catchPhrases.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (string value in catchPhrases.Values)
            {
                Console.WriteLine(value);
            }

            foreach (KeyValuePair<string,string> kvp in catchPhrases)
            {
                Console.WriteLine(kvp);
                Console.WriteLine(kvp.Value);
                Console.WriteLine(kvp.Key);
            }

            for (int i = 0; i < muppets1.Count; i++)
            {
                Console.WriteLine(muppets1[i].ToCharArray()[0..3]);
            }

            foreach (string s in muppets1.OrderByDescending(x => x))
            {
                Console.WriteLine(s);
            }

            List<int> array = new List<int>();
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
                
                array.Add(inputParsed);
            }

            decimal sum = 0;
            int index = 0;
            while (index < array.Count)
            {
                sum += array[index++];
            }

            Console.WriteLine(sum / array.Count);

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

