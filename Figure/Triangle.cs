using System;

namespace Figure
{
    public class Triangle :FigureBase
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;
        public Triangle(double sideA,double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override double GetAcreage()
        {
            var semiPerimeter = (sideA + sideB + sideC) / 2;

            var surface = Math.Sqrt( semiPerimeter 
                                     * (semiPerimeter - sideA) 
                                     * (semiPerimeter - sideB) 
                                     * (semiPerimeter - sideC));

            return surface;
        }

        /// <summary>
        /// Является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>true - если прямоугольный</returns>
        public bool IsRightTriangle()
        {
            var sumSquaresLegs = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
            var hypotenuseSquare = Math.Pow(sideC, 2);
            
            return  Math.Abs(sumSquaresLegs - hypotenuseSquare) < 0.1f;
        }
    }
}
