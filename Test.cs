
namespace ExerciseOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            var triangle = new Triangle(2, 6);

            var rectangle = new Rectangle(2, 6);

            var circle = new Circle(4, 4);

            var listOfShapes = new List<Shape> { triangle, rectangle, circle };

            foreach (var shape in listOfShapes)
            {
                Console.WriteLine("The {0} has area = {1}",shape.GetType(),shape.CalculateSurface());
            }

        }
    }
}
