namespace Model;

[Serializable]
public class Triangle : GeometricShape
{
    public double
        _height, _footing;

    public double Height 
    {
        get => _height;
        set => _height = ValidateAndReturn(value);
    }

    public double Footing
    {
        get => _footing;
        set => _footing = ValidateAndReturn(value);
    }

    public Triangle(double heght, double footing)
    {
        Height = heght;
        Footing = footing;
    }

    public Triangle() { }

    public override double CountSquare() =>
        Height * Footing / 2;
}
