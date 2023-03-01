public class CircleShape : Shape {
    double _radius;

    public CircleShape(string color, double radius){
        _color = color;
        _radius = radius;
    }
    public override double GetArea(){
        double area = Math.PI * _radius * _radius;
        Console.WriteLine($"The circle is {_color} and its area is {area}");
        return area;
    }
}