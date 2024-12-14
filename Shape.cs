using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07.Classes
{
    public abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");

        }
        public abstract double CalculateArea();
    }

    public class ShapeRectangle : Shape
    {
        private double width;
        private double height;

        public ShapeRectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double CalculateArea()
        {
            return width * height;
        }


    }
}
