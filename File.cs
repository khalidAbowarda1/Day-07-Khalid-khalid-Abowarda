using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day07.Interfaces;

namespace Day07.Classes
{
    public class File : IReadable, IWritable
    {
        public void Read()
        {
            Console.WriteLine("Reading File");
        }

        public void Write()
        {
            Console.WriteLine("Reading File");
        }


    }
}
