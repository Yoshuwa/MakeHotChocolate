using System;

namespace YoshuwaKalangu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What drink would you like today?");
            var _userInput = Console.ReadLine() ?? string.Empty;
            HotDrinkOptions.MakeHotBeverage(_userInput);
            Console.ReadLine();
        }
    }
}
