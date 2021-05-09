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


        public override double GetAcreage()
        {
            var semiPerimeter = (sideA + sideB + sideC) / 2;

            var surface = Math.Sqrt( semiPerimeter 
                                     * (semiPerimeter - sideA) 
                                     * (semiPerimeter - sideB) 
                                     * (semiPerimeter - sideC));

            return surface;
        }
    }
}
