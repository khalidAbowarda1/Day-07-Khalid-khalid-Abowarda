using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07.Classes
{
    public class Child : Parent
    {
        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public new int Product()
        {
            return X * Y * Z;
        }

        // 2. Override it using the override keyword. >> ERROr
        //Type 'Child' already defines a member called 'Product' with the same parameter types

        public override string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }
    }
}
