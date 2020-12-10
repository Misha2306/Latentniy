using System;

interface ICoordinates
{
    double X { get; set; }
    double Y { get; set; }
}
interface ISize
{
    double Width { get; set; }
    double Height { get; set; }

    double Perimeter();
}
struct Rectangle : ISize, ICoordinates
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double X { get; set; }
    public double Y { get; set; }

    public Rectangle(double width, double height, double x, double y)
    {
        Width = width;
        Height = height;
        X = x;
        Y = y;
    }
    public double Perimeter()
    {
        return 2 * Width + 2 * Height;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter rectangle width, height, x and y, separated by spaces: ");
        var input = Console.ReadLine().Split(' ');

        var rect = new Rectangle(double.Parse(input[0]),
            double.Parse(input[1]),
            double.Parse(input[2]),
            double.Parse(input[3]));

        Console.WriteLine(
            "Rectangle:\n\t" +
            $"Width: {rect.Width}\n\t" +
            $"Height: {rect.Height}\n\t" +
            $"Perimeter: {rect.Perimeter()}\n\t" +
            $"X: {rect.X}\n\t" +
            $"Y: {rect.Y}");

        Console.ReadKey();
    }
}
