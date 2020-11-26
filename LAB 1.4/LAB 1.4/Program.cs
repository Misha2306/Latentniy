using System;
namespace Number
{
    class mathematics
    {
        static void Main()
        {
            Console.WriteLine("Вибери число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Число вибране: " + number);
            double round = Math.Round(number);
            Console.WriteLine("Заокруглення до найбільшого значення: " + round);
            double floor = Math.Floor(number);
            Console.WriteLine("Заокруглення до меншого значення: " + floor);
        }
    }
}