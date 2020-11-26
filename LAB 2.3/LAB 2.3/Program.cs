using System;
namespace Program
{
    class People
    {
        static void Main(string[] args)
        {
            string ask, change;
            Console.WriteLine("Введіть речення...");
            ask = Console.ReadLine();
            if (ask.Contains("a"))
            {
                change = ask.Replace("a", "u");
                Console.WriteLine("Результат: " + change);
            }
            else
            {
                Console.WriteLine("Спробуйте ще раз.");

            }
        }
    }
}
