using System;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleApp1
{
    class Program
    {
        private static string result;

        static void Main(string[] args)
        {
            SaySomething();
            Console.WriteLine(result);
            Console.WriteLine("stuff");
        }
        static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            result = "Hello World";
            return "Something";
        }
    }
}