using System;
using Day07.Classes;

namespace Day07.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // o Demonstrate the constructors by creating objects.>> problem 1
            Car car1 = new Car();
            Car car2 = new Car(1);
            Car car3 = new Car(2, "BMW");
            Car car4 = new Car(3, "Toyota", 75000);

            //*********************************************************************


            // o Write a program to test each overload. >> problem 2
            Calculator calc = new Calculator();
            Console.WriteLine($"Sum of 2 integers: {calc.sum(5, 4)}");
            Console.WriteLine($"Sum of 3 integers: {calc.sum(5, 4, 9)}");
            Console.WriteLine($"Sum of 2 doubles: {calc.sum(5.5, 4.7)}");


            //*********************************************************************

            //o Demonstrate constructor chaining by creating an instance of Child. problem 3
            Parent parent = new Parent(5, 4);
            Child child = new Child(5, 4, 6);

            // Question: How does new differ from override in method overriding? problem 4
            Console.WriteLine($"Parent Product():{parent.Product()} ");
            Console.WriteLine($"Child Product():{child.Product()} ");

            // o Demonstrate polymorphism by printing instances of both Parent and Child. problem 5
            Console.WriteLine($"Parent ToString():{parent.ToString()} ");
            Console.WriteLine($"Child ToString():{child.ToString()} ");

            //***********************************************************************

            //o Test the implementation. problem 6
            Ishape rectangle = new Rectangle(5, 4);
            rectangle.Draw();
            rectangle.PrintDetails();

            // problem 7
            Ishape circle = new Circle(3);
            circle.Draw();
            circle.PrintDetails();

            //*************************************************************************

            // problem 8
            IMovable car5 = new MovableCar();
            car5.Move();

            //*************************************************************************

            // problem 9
            File file = new File();
            file.Read();
            file.Write();

            //*************************************************************************

            // problem 10
            Shape shape = new ShapeRectangle(6, 4);
            shape.Draw();
            Console.WriteLine($"Rectangle Area: {shape.CalculateArea()}");

            //-----------------------------------------------------------------------------------------------------





        }
    }
}
