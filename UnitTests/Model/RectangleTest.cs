using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Model;
using NUnit.Framework;
namespace UnitTests.Model;

[TestFixture]
public class RectangleTest
{
    [Test]
    [TestCase(4, TestName = "Тестирование Height при Height = 4.")]
    [TestCase(Double.MaxValue, TestName = "Тестирование Height при Height = Double.MaxValue.")]
    [TestCase(Double.MinValue, TestName = "Тестирование Height при Height = Double.MaxValue.")]
    [TestCase(-1, TestName = "Тестирование Height при Height =  -1.")]
    [TestCase(0, TestName = "Тестирование Height при Height =  0.")]
    public void HeightTest(double height)
    {
        var c = new Rectangle();
        if (height <= 0)
            Assert.Throws<ArgumentException>(() => c.Height = height);
        else
            c.Height = height;
    }

    [Test]
    [TestCase(4, TestName = "Тестирование Width при Width = 4.")]
    [TestCase(Double.MaxValue, TestName = "Тестирование Width при Width = Double.MaxValue.")]
    [TestCase(Double.MinValue, TestName = "Тестирование Width при Width = Double.MaxValue.")]
    [TestCase(-1, TestName = "Тестирование Width при Width =  -1.")]
    [TestCase(0, TestName = "Тестирование Width при Width =  0.")]
    public void WidthTest(double width)
    {
        var c = new Rectangle();
        if (width <= 0)
            Assert.Throws<ArgumentException>(() => c.Width = width);
        else
            c.Width = width;
    }

    [Test]
    [TestCase(4, -4, TestName = "Тестирование CountSquare при Height = 4, Width = -4.")]
    [TestCase(Double.MaxValue, Double.MaxValue, TestName = "Тестирование CountSquare при Height = Double.MaxValue, Width = Double.MaxValue.")]
    [TestCase(Double.MinValue, Double.MaxValue, TestName = "Тестирование CountSquare при Height = Double.MaxValue, Width = Double.MaxValue.")]
    [TestCase(-1,-1, TestName = "Тестирование CountSquare при Height =  -1, Width =  -1.")]
    [TestCase(0,0, TestName = "Тестирование CountSquare при Height =  0, Width = 0.")]
    [TestCase(1, 1, TestName = "Тестирование CountSquare при Height =  1, Width = 1.")]
    public void CountSquareTest(double height, double width)
    {
        var c = new Rectangle();
        if (height <= 0 || width <= 0)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                c.Height = height;
                c.Width = width;
            });
        }
        else
        {
            c.Height = height;
            c.Width = width;

            Assert.Positive(c.CountSquare());
            Assert.IsTrue(c.CountSquare() == height * width);
        }
    }
}
