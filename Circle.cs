
namespace ExerciseOne
{
    using System;
    class Circle : Shape
    {
        private const double devideByTwo = 2;
        public Circle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
            
            if(width != height)
            {
                throw new ArgumentException("Width and Height must be equal");
            }
        }
     
        public override double CalculateSurface()
        {
            double surface = Math.PI * Math.Pow((Width / devideByTwo), 2);

            return surface;
        }

    }
}
