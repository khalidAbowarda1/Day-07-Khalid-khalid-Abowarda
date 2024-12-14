using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07.Interfaces
{
    internal interface Ishape
    {
        double Area { get; }
        void Draw();

        void PrintDetails()
        {
            Console.WriteLine($"Shape With Area: {Area}");
        }
    }
}
