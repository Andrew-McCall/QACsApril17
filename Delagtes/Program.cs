namespace Delagtes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListKeeper lk = new ListKeeper();
            lk.ints.Add(10);
            lk.ints.Add(20); 
            lk.ints.Add(30);
            lk.ints.Add(40);
            lk.ints.Add(50);
            lk.ints.Add(60);
            lk.ints.Add(61);

            Console.WriteLine( lk.ints );
            Console.WriteLine( lk.Search(IsMoreThan40) );
            Console.WriteLine( lk.Search(IsOdd) );
            Console.WriteLine( lk.Search( (a) => a==30) );
            Console.WriteLine( lk.Search( (a) => { return a > 30; }) );

            lk.forEachAction((a) => Console.Write($"{a},"));
            Console.WriteLine();

            lk.map( (anything) => anything / 5 );

            lk.forEachAction((a) => Console.Write($"{a},"));
            Console.WriteLine();
        }

        static bool IsMoreThan40(int a)
        {
            return a > 40;
        }

        static bool IsOdd(int a)
        {
            return a%2 == 1;
        }

    }

}