using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Day07.Interfaces;

namespace Day07.Classes
{
    internal class MovableCar : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is Moving");
        }
    }
}
