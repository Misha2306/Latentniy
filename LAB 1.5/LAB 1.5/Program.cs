using System;
namespace Division
{
    class Mathematics
    {
        static void Main()
        {
            Console.WriteLine("Вибери число (n>2): ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Число вибране: " + number);
            if (number <= 0 || number % 2 == 0)
            {
                Console.WriteLine("Код не працюватиме через недопустимість значень, повторіть спробу.");
            }
            else
            {
                double division_by_2 = number / 2;
                Console.WriteLine("Ділення вашого числа на 2: " + division_by_2);
                double round = Math.Round(division_by_2, 2);
                Console.WriteLine("Округлення до сотих вашого числа: " + round);

            }

        }
    }
}