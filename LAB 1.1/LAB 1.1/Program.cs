using System;
namespace Program
{
    class Circle
    {
        static void Main(string[] args)
        {
           int power = 2;
           Console.WriteLine("The radius ");
           double radius = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("The radius of the circle  " + radius);
           double area = Math.PI * Math.Pow(radius, power);
           Console.WriteLine("The area of the circle " + area);
        }
    }
}