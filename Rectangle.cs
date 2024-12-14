using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day07.Interfaces;

namespace Day07.Classes
{
    internal class Rectangle : Ishape
    {

        private double width;
        private double height;


        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area => width * height;


        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }


    }
}
