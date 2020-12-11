using System;

public enum Colors
{
    Pink= 77,
    Grey= 43,
    Red = 17,
    Orange = 5,
    Silver = 2,
    Gold = 1,
    Green = 133
}
public static class Extensions
{
    public static void PrintColors(this Colors color)
    {
        // Getting values array of our enum and casting it to int[]
        var values = (int[])Enum.GetValues(color.GetType());

        Array.Sort(values);

        foreach (var t in values)
        {
            Console.WriteLine($"{(Colors)t} = {t}");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Colors someColor = Colors.Red;
        someColor.PrintColors();

        Console.ReadKey();
    }
}
