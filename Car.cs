using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day07.Classes
{
    public class Car
    {
        // properties
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        //1. Default constructor. 
        public Car()
        {
            Id = 0;
            Brand = string.Empty;
            Price = 0;

        }

        // 3. Constructor with one parameter (Id).
        public Car(int id)
        {
            Id = id;
            Brand = string.Empty;
            Price = 0;

        }

        //3. Constructor with two parameters (Id, Brand).
        public Car(int id, string brand)
        {
            Id = id;
            Brand = brand;
            Price = 0;
        }

        // 4. Constructor with all three parameters.
        public Car(int id, string brand, decimal price)
        {
            Id = id;
            Brand = brand;
            Price = price;
        }

    }
}
