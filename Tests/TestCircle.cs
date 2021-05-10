using System;
using NUnit.Framework;
using Figure;

namespace Tests
{
    [TestFixture]
    public class TestCircle
    {
        [Test]
        public void CalculateCircleAcreage()
        {
            FigureBase figure = new Circle(5);
            
            var resultValue = figure.GetAcreage();
            var expectedValue = 78.53;
            
            Assert.That(Math.Abs(resultValue - expectedValue) < 0.1f);
        }
        
        [Test]
        public void RadiusAreNegativeNumber()
        {
            var expectedMessage = "Радиус должен быть положительным числом.";
            
            var resultException = Assert.Throws<ArgumentException>(() => {
                new Circle(-5);;
            });
            Assert.AreEqual(expectedMessage, resultException.Message);
        }
        
        
    }
}
