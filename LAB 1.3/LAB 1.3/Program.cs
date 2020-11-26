using System;
class Number
{
    static int Main()
    {

        int m, n;
        Console.WriteLine("Вибери m (1<m<5)...");
        m = int.Parse(Console.ReadLine());
        if (m < 1 || m > 5)
        {
            Console.WriteLine("Код не працюватиме через недопустимість значень");
            return 0;
        }
        Console.WriteLine("Вибери n (1<n<5)");
        n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 5)
        {
            Console.WriteLine("Код не працюватиме через недопустимість значень");
            return 0;
        }
        Console.WriteLine("m^n=" + Math.Pow(m, n));
        return 0;
    }
}