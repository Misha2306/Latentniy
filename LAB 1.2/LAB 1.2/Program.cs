using System;
namespace Cube
{
    class Cubes
    {
        static void Main(string[] args)
        {
            int side_power = 3;
            Console.WriteLine("Вибери сторону кубу: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сторона кубу :  " + side);
            double area = Math.Pow(side, side_power);
            Console.WriteLine("Площа кубу: " + area);
        }
    }
}