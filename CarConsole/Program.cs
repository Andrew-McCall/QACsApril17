using CarLibrary;

namespace CarConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Console.WriteLine(c1);

            Car c2 = new Car("Audi", "TT");
            c2.Speed = 30;
            Console.WriteLine(c2);

            Car c3 = new Car("BMW", "X5")
            {
                Colour = "Grey",
                RegistrationNumber = "ABC 123",
                Model = "Override"
            };
            Console.WriteLine(c3);

            Car c4 = new Car("BMW", "X5", "Hot Pink");
            Console.WriteLine(c4);
        }
    }
}