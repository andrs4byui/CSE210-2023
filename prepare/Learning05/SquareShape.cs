public class SquareShape : Shape{
    public double _side;
    public SquareShape(string color, double side){
        _color = color;
        _side = side;
    }
    public override double GetArea(){
        double area = _side * _side;
        Console.WriteLine($"The square is {_color} and its area is {area}");
        return area;
    }
}

