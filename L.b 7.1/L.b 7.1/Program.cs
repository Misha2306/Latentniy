using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public IEnumerable<string> PhoneNumbers { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Person> Person_List = new List<Person>
            {
                new Person
                {
                    Name = "Mike",
                    Age = 17,
                    PhoneNumbers = new List<string>(){"+380(97)003-87-91", "+380(97)003-87-92"}
                },
                new Person
                {
                    Name = "Каte",
                    Age = 12,
                    PhoneNumbers = new List<string>(){"+380(67)230-40-22", "+380(67)236-00-72"}
                },
                new Person
                {
                    Name = "Vania",
                    Age = 17,
                    PhoneNumbers = new List<string>(){ "+380(97)321-70-51", "+380(97)340-55-72"}
                },
                new Person
                {
                    Name = "Bogdana",
                    Age = 16,
                    PhoneNumbers = new List<string>(){ "+380(63)167-95-71", "+380(63)547-20-99"}
                },
                new Person
                {
                    Name = "Illia",
                    Age = 15,
                    PhoneNumbers = new List<string>(){"+380(63)766-44-34", "+380(63)346-72-22" }
                },
                new Person
                {
                    Name = "Nazar",
                    Age = 19,
                    PhoneNumbers = new List<string>(){"+380(67)165-41-18", "+380(67)441-56-32" }
                },
            };

        foreach (var person in Person_List)
        {
            Console.WriteLine($"Name: {person.Name}\nAge:{person.Age}\n");
        }

        foreach (var item in Person_List)
        {
            Console.WriteLine("\n {0} phone numbers:", item.Name);
            foreach (var number in item.PhoneNumbers)
            {
                Console.WriteLine("\t -{0}", number);
            }
        }
    }
}
