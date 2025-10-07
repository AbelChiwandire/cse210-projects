using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("black", 3);
        shapes.Add(s1);

        Square s2 = new Square("white", 5.5);
        shapes.Add(s2);

        Rectangle s3 = new Rectangle("black", 7, 2);
        shapes.Add(s3);

        Rectangle s4 = new Rectangle("white", 9, 3);
        shapes.Add(s4);

        Rectangle s5 = new Rectangle("maroon", 10, 2);
        shapes.Add(s5);

        Circle s6 = new Circle("blue", 4);
        shapes.Add(s6);

        Circle s7 = new Circle("yellow", 7);
        shapes.Add(s7);

        foreach (var shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"{shape} => Color:{color}, Area:{area}");
        }
    }
}