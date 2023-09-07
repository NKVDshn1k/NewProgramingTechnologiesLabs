﻿
namespace Model;

[Serializable]
public abstract class GeometricShape
{
    public string TypeName =>
        this.GetType().Name;
    public abstract double CountSquare();
    protected double ValidateAndReturn(double size)
    {
        if (size <= 0)
            throw new ArgumentException("Size param must be more than zero");
        return size;
    }
}