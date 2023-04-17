namespace MathsLibrary
{
    // Hint to the users, this has classses for other things to use
    public class Calculator 
    {
        
        public static void Run()
        {
            Console.WriteLine("Enter a number Space operation Space number:");
            string? userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput)) throw new Exception("invaild input");

            string[] inputs = userInput.Split(" ");

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[2]);

            switch (inputs[1][0]) // takes first char so char is primitive compare
            {
                case '+':
                    Console.WriteLine(Calculator.Add(a, b));
                    break;
                case '-':
                    Console.WriteLine(Calculator.Subtraction(a, b));
                    break;
                case '*':
                    Console.WriteLine(Calculator.Multiply(a, b));
                    break;
                case '/':
                    Console.WriteLine(Calculator.Divison(a, b));
                    break;
                default:
                    throw new Exception("Invaild Operation");
            }

        }

        public static int Add(int a, int b)
        {
            return a+b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static int Subtraction(int a, int b)
        {
            return a-b;
        }

        public static double Divison(double a, double b)
        {
            return a/b;
        }

        // Extention
        public static int Modulo(int a, int b)
        {
            return a%b;
        }
        // ExtentionTwo
        public static double ExponentialLog(double a, double b)
        {
            return Math.Log(a, b);
        }
    }
}