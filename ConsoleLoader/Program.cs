// See https://aka.ms/new-console-template for more information
using Model;

Console.WriteLine("Hello, World!");


GeometricShape shpe = new Circle();
shpe.SetFromConsole();
Console.WriteLine(shpe.CountSquare());

shpe = new Rectangle();
shpe.SetFromConsole();
Console.WriteLine(shpe.CountSquare());

shpe = new Triangle();
shpe.SetFromConsole();
Console.WriteLine(shpe.CountSquare());