using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle("green", 5));
        shapes.Add(new Rectangle("blue",5, 10));
        shapes.Add(new Square("Red",5));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine("The {0} shape has an area of {1}", color, area);
        }
    }
}