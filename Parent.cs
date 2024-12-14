using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07.Classes
{
    public class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        // problem 4
        public virtual int Product()
        {
            return X * Y;
        }

        // Problem 5
        public override string ToString()
        {
            return $"({X} , {Y})";
        }
    }
}
