using System;
namespace Program
{
    class People
    {
        static void Main(string[] args)
        {
            String first, second, first_lower, second_lower;
            Console.WriteLine("Введіть перше ім'я.");
            first = Console.ReadLine();
            Console.WriteLine("Введіть друге ім'я.");
            second = Console.ReadLine();
            first_lower = first;
            first_lower = first.ToLower();
            Console.WriteLine("З маленької літери перше ім'я: " + first_lower);
            second_lower = second;
            second_lower = second.ToLower();
            Console.WriteLine("З маленької літери друге ім'я: " + second_lower);

        }
    }
}