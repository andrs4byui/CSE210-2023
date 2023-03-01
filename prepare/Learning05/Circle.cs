public class Circle : Shape {
    double _radius;

    public Circle(string color, double radius){
        _color = color;
        _radius = radius;
    }
    public override double GetArea(){
        double area = Math.PI * _radius * _radius;
        return area;
    }
}