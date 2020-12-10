using System;

public enum Months
{
    January,
    Feburary,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}
class Program
{
    static void Main(string[] args)
    {
        int n;

        Console.Write("Enter integer (0 to 11): ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Month in enum, corresponding to that number: {(Months)n-1}");

        Console.ReadKey();
    }
}
