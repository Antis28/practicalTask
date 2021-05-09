using System;
using Figure;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(3, 4, 5);
            var result = triangle.GetAcreage();
            Console.WriteLine(result);
            
            var circle = new Circle(5);
            result = circle.GetAcreage();
            Console.WriteLine(result);
        }
    }
}
