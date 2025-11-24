using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 4.0);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 3.0, 5.0);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 2.5);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}