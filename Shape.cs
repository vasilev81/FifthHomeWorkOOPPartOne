
namespace ExerciseOne
{
    using System;
    public abstract class Shape
    {
        private double width;
        private double height;
          
        public double Width 
        { 
            get
            {
                return this.width;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Value cannot be zero ot less");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value cannot be zero ot less");
                }
                this.height = value;
            }
        }

        public abstract double CalculateSurface();        
    }
}
