using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(10, "red");
        Console.WriteLine("Square test:");
        Console.WriteLine(square.GetArea());
        Console.WriteLine(square.GetColor());
        Console.WriteLine("");

        Console.WriteLine("Rectangle test:");
        Rectangle rectangle = new Rectangle(5, 10, "blue");
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine("");

        Console.WriteLine("Circle test:");
        Circle circle = new Circle(5, "green");
        Console.WriteLine(circle.GetArea());
        Console.WriteLine(circle.GetColor());
        Console.WriteLine("");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
            Console.WriteLine("");
        }

    }
}