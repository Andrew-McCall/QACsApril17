
namespace Exceptions.Exceptions.Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;
            try
            {
                i++;
                Console.WriteLine("Try");
                Errorererr();

            }
            catch(MyCustomException ex) when (ex.MinorFault && i == 1) // any conditon
            {
                Console.WriteLine("Ignore error, tis minor");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Catch");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finally"); // Will always happen.
                // Cleanup
            }

        }

        static void Errorererr()
        {
            throw new Exception("message", new MyCustomException(false));
        }
    }

}