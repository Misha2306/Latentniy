using System;
namespace Number
{
    class Mathematics
    {
        static void Main()
        {
            Console.WriteLine("Вибери число (d>0): ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Число вибране: " + d);
            if (d < 0)
            {
                Console.WriteLine("Наш код не буде працювати. Будь ласка, виберіть інше значення. Пам'ятайте, що d не повинно бути менше за 0");
            }
            else
            {
                double s = Math.Ceiling(d);
                Console.WriteLine("Найбільше значення d : " + s);
                double square_root = Math.Sqrt(s);
                Console.WriteLine("Корінь квадратний з S дорівнює: " + square_root);

            }

        }
    }
}