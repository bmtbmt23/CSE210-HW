using System;

public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public Rectangle(double lenght, double width, string color) : base (color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}