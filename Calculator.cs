using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07.Classes
{
    internal class Calculator
    {
        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public double sum(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
