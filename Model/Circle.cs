namespace Model;

[Serializable]
public class Circle : GeometricShape
{
    private double radius;
    public double Radius 
    {
        get => radius;
        set => radius = ValidateAndReturn(value); 
    }

    public Circle(double radius) 
    {
        Radius = radius;
    }

    public override double CountSquare() =>
        2 * Math.Pow(Radius, 2) * Math.PI;
}
