using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square();
        square1.SetColor("Blue");
        square1.SetSide(3);

        Rectangle rectangle1 = new Rectangle();
        rectangle1.SetColor("Red");
        rectangle1.SetLength(5);

        Circle circle1 = new Circle();
        circle1.SetColor("Green");
        circle1.SetRadius(6); 

        DisplayShapeArea(square1);
        DisplayShapeArea(rectangle1);
        DisplayShapeArea(circle1);
    }

    public static void DisplayShapeArea(Shape shape)
    {
        Console.WriteLine($"Shape Area: {shape.GetArea()} and Color: {shape.GetColor()}");
    }
}