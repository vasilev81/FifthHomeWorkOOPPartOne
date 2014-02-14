
namespace ExerciseOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Rectangle : Shape
    {
        public Rectangle(double width, double heigth)
        {
            this.Width = width;
            this.Height = heigth;
        }

        public override double CalculateSurface()
        {
            double surface = Width * Height;

            return surface;
        }
    }
}
