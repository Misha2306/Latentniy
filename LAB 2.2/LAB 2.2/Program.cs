using System;

namespace Comparison_of_two
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше ім'я: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Введіть друге ім'я: ");
            string secondname = Console.ReadLine();

            bool result = firstname.Equals(secondname, System.StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Ordinal Comparison: {0} and {1} are {2}", firstname, secondname, result ? "equal. " : "not equal. "); //сравнить строчки, не считая uppercase и lowercase
            Console.WriteLine("Довжина першого імені становить: " + firstname.Length);
            Console.WriteLine("Довжина другого імені становить: " + secondname.Length);
            if (firstname.Length > secondname.Length)
            {
                Console.WriteLine(firstname + " is larger than " + secondname);
            }
            else if (firstname.Length == secondname.Length)
            {
                Console.WriteLine(firstname + " is equal to " + secondname);
            }
            else
            {
                Console.WriteLine(secondname + " is larger than " + firstname);
            }
            if (firstname[firstname.Length - 1] == secondname[secondname.Length - 1])
            {
                Console.WriteLine("Останні елементи є рівними.");
            }
            else
            {
                Console.WriteLine("Останні елементи не є рівними.");
            }




        }

    }
}