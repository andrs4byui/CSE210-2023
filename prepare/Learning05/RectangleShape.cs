public class RectangleShape : Shape{
    public double _length;
    public double _width;
    
    public RectangleShape(string color, double length, double width){
        _color = color;
        _length = length;
        _width = width;
    }
    public override double GetArea(){
        double area = _length * _width;
        Console.WriteLine($"The rectangle is {_color} and its area is {area}");
        return area;
    }
}

