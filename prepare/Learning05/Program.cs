using System;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square("red", 5);
        square.GetColor();
        Console.WriteLine(square.GetArea());
    }
}