// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using Figure;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestTriangle
    {
        [Test]
        public void CalculateTriangleAcreage_result5()
        {
            FigureBase figure = new Triangle(3, 4, 5);
            
            var resultValue = figure.GetAcreage();
            var expectedValue = 6;
            
            Assert.That(Math.Abs(resultValue - expectedValue) < 0.1f);
        }
        
        [Test]
        public void TriangleAreRight()
        {
            var figure = new Triangle(3, 4, 5);
            
            var resultValue = figure.IsRightTriangle();
            var expectedValue = true;
            
            Assert.AreEqual(expectedValue, resultValue);
        }
        
        [Test]
        public void TriangleAreNotRight()
        {
            var figure = new Triangle(5, 6, 7);
            
            var resultValue = figure.IsRightTriangle();
            var expectedValue = false;
            
            Assert.AreEqual(expectedValue, resultValue);
        }
    }
}
