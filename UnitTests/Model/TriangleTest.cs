using Model;
using NUnit.Framework;

namespace UnitTests.Model;

[TestFixture]
public class TriangleTest
{
    [Test]
    [TestCase(4, TestName = "Тестирование Height при Height = 4.")]
    [TestCase(Double.MaxValue, TestName = "Тестирование Height при Height = Double.MaxValue.")]
    [TestCase(Double.MinValue, TestName = "Тестирование Height при Height = Double.MaxValue.")]
    [TestCase(-1, TestName = "Тестирование Height при Height =  -1.")]
    [TestCase(0, TestName = "Тестирование Height при Height =  0.")]
    public void HeightTest(double height)
    {
        var c = new Triangle();
        if (height <= 0)
            Assert.Throws<ArgumentException>(() => c.Height = height);
        else
            c.Height = height;
    }

    [Test]
    [TestCase(4, TestName = "Тестирование Footing при Footing = 4.")]
    [TestCase(Double.MaxValue, TestName = "Тестирование Footing при Footing = Double.MaxValue.")]
    [TestCase(Double.MinValue, TestName = "Тестирование Footing при Footing = Double.MaxValue.")]
    [TestCase(-1, TestName = "Тестирование Footing при Footing =  -1.")]
    [TestCase(0, TestName = "Тестирование Footing при Footing =  0.")]
    public void FootingTest(double footing)
    {
        var c = new Triangle();
        if (footing <= 0)
            Assert.Throws<ArgumentException>(() => c.Footing = footing);
        else
            c.Footing = footing;
    }

    [Test]
    [TestCase(4, -4, TestName = "Тестирование CountSquare при Height = 4, Footing = -4.")]
    [TestCase(Double.MaxValue, Double.MaxValue, TestName = "Тестирование CountSquare при Height = Double.MaxValue, Footing = Double.MaxValue.")]
    [TestCase(Double.MinValue, Double.MaxValue, TestName = "Тестирование CountSquare при Height = Double.MaxValue, Footing = Double.MaxValue.")]
    [TestCase(-1, -1, TestName = "Тестирование CountSquare при Height =  -1, Footing =  -1.")]
    [TestCase(0, 0, TestName = "Тестирование CountSquare при Height =  0, Footing = 0.")]
    [TestCase(1, 1, TestName = "Тестирование CountSquare при Height =  1, Footing = 1.")]
    public void CountSquareTest(double height, double footing)
    {
        var c = new Triangle();
        if (height <= 0 || footing <= 0)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                c.Height = height;
                c.Footing = footing;
            });
        }
        else
        {
            c.Height = height;
            c.Footing = footing;

            Assert.Positive(c.CountSquare());
            Assert.IsTrue(c.CountSquare() == height * footing / 2);
        }
    }
}
