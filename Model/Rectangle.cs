namespace Model;

[Serializable]
public class Rectangle : GeometricShape
{
    private double 
        _height, 
        _width;
    public double Height 
    {
        get => _height;
        set => _height = ValidateAndReturn(value);
    }
    public double Width
    {
        get => _width;
        set => _width = ValidateAndReturn(value);
    }


    public Rectangle(double heght, double width)
    {
        Height = heght;
        Width = width;
    }

    public override double CountSquare() =>
        Height * Width;
}
