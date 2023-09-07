using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Model;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace UnitTests.Model;

[TestFixture]
public class CircleTest
{
    [Test]
    [TestCase(4, TestName = "Тестирование Radius при Radius = 4.")]
    [TestCase(Double.MaxValue, TestName = "Тестирование Radius при Radius = Double.MaxValue.")]
    [TestCase(Double.MinValue, TestName = "Тестирование Radius при Radius = Double.MaxValue.")]
    [TestCase(-1, TestName = "Тестирование Radius при Radius =  -1.")]
    [TestCase(0, TestName = "Тестирование Radius при Radius =  0.")]
    public void RadiusTest(double radius)
    {
        var c = new Circle();
        if (radius <= 0)
            Assert.Throws<ArgumentException>(() => c.Radius = radius);
        else
            c.Radius = radius;
    }

    [Test]
    [TestCase(4, TestName = "Тестирование CountSquare при Radius = 4.")]
    [TestCase(Double.MaxValue, TestName = "Тестирование CountSquare при Radius = Double.MaxValue.")]
    [TestCase(Double.MinValue, TestName = "Тестирование CountSquare при Radius = Double.MaxValue.")]
    [TestCase(-1, TestName = "Тестирование CountSquare при Radius =  -1.")]
    [TestCase(0, TestName = "Тестирование CountSquare при Radius =  0.")]
    public void CountSquareTest(double radius)
    {
        var c = new Circle();
        if (radius <= 0)
            Assert.Throws<ArgumentException>(() => c.Radius = radius);
        else
        {
            c.Radius = radius;

            Assert.Positive(c.CountSquare());
            Assert.IsTrue(c.CountSquare() == (2 * Math.Pow(radius, 2) * Math.PI));
        }
    }
}
