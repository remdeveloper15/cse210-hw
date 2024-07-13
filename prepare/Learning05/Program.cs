using System;

class Program
{
    static void Main(string[] args)
    {
        Square _shape = new Square("Red ", 2);
        //Console.Write("Color: " + _shape.GetColor());
        //Console.WriteLine("Area: " + _shape.GetArea());

        Rectangle _shape1 = new Rectangle("Blue ", 2, 2);
        //Console.Write("Color: " + _shape1.GetColor());
        //Console.WriteLine("Area: " + _shape1.GetArea());

        Circle _shape2 = new Circle("Yellow ", 2);
        //Console.Write("Color: " + _shape2.GetColor());
        //Console.WriteLine("Area: " + _shape2.GetArea());

        List<Shape> _shapes = new List<Shape>();
        _shapes.Add(_shape);
        _shapes.Add(_shape1);
        _shapes.Add(_shape2);

        foreach (Shape s in _shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }

    }
}