// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;

namespace Figure
{
    public class Circle : FigureBase
    {
        private readonly double radius;
        
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }
            this.radius = radius;
        }

        public override double GetAcreage()
        {
            var square = 2;
            var result = Math.PI * Math.Pow(radius, square);

            return result;
        }
    }
}
