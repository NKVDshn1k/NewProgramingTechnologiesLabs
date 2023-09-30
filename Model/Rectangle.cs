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

    public Rectangle() { }

    public override double CountSquare() =>
        Height * Width;

    public override void SetFromConsole()
    {
        Console.Write(TypeName + "\nHeight = ");
        Height = ReadDouble();
        Console.Write("Width = ");
        Width = ReadDouble();
    }
}
