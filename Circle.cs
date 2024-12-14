using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day07.Interfaces;

namespace Day07.Classes
{
    public class Circle : Ishape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area => Math.PI * radius * radius;

        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
