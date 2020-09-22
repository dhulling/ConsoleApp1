using System;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleApp1
{
    class Program
    {
        private static string result;

        static async Task Main(string[] args)
        {
            await SaySomething();
            Console.WriteLine(result);
            Console.WriteLine("Supren Supren, Suben Suben, Maldeskstra dekstra, Maldeskstra dekstra, Bee Aye Komenco!!\r");
        }
        static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            result = "Saluton Mondo!\n";
            return "Something";
        }
    }
}