using ClassLibrary1;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Calci c = new Calci();
            Console.WriteLine(c.Add());
        }
    }
}
