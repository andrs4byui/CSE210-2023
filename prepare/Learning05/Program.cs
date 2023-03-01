using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        SquareShape square = new SquareShape("red", 5);
        RectangleShape rectangle = new RectangleShape("red", 5, 2);
        CircleShape circle = new CircleShape("Yellow", 3);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes){
            shape.GetColor();
            shape.GetArea();
        }


    }
}