using System;

namespace L.B_5._1
{
    struct Person
    {
        private string _firstname, _lastname;
        private byte _age;

        public Person(string firstname, string lastname, byte age)
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = age;
        }

        public string IsOlderThan(byte n)
        {
            if (_age > n)
            {
                return $"{_firstname} {_lastname} is older than {n}.";
            }
            if (_age < n)
            {
                return $"{_firstname} {_lastname} is younger than {n}.";
            }
            return $"{_firstname} {_lastname} is exactly {n} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter person's name, surname and age, separated by spaces: ");
            var input = Console.ReadLine().Split(' ');

            var person = new Person(input[0], input[1], byte.Parse(input[2]));

            Console.Write("Enter random number N (N > 0): ");
            var n = byte.Parse(Console.ReadLine());

            Console.WriteLine(person.IsOlderThan(n));

            Console.ReadKey();
        }
    }

    
}
