
namespace ExerciseOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Triangle : Shape
    {
        private const double devideByTwo = 2;

        public Triangle(double width, double height) 
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculateSurface()
        {
            double surface = (Width * Height) / devideByTwo;

            return surface;
        }
    }
}
