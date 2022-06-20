using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Assignment3
{
    internal class SumOfTwoNums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of " + a + " + " + b + " = " + (a + b));
        }
    }
     class sibtraction 
     { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Subtraction of " + a + " - " + b + " = " + (a - b));
        }
    }
    class Multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Multiplication of " + a + " * " + b + " = " + (a * b));
        }
    }

    class Division
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Division of " + a + " / " + b + " = " + (a / b));
        }
    }

    class areaOfRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth: ");
            int b = int.Parse(Console.ReadLine());

            int aor = l * b;
            Console.WriteLine("Area of rectangle is: "+aor);
        }
    }

    class areaOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth: ");
            int b = int.Parse(Console.ReadLine());

            int aot = (h * b) / 2;
            Console.WriteLine("Area of triangle is: "+aot);
        }
    }

    class sqrOfNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Square of "+a+" is :"+(a*a));
        }
    }

    class cubeOfNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Cube of " + a + " is :" + (a * a * a));
        }
    }

    class convertLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance in cm: ");
            int a = int.Parse(Console.ReadLine());

            float meter = a / 100f;
            float kilometer = a / 100000f;
            Console.WriteLine("In meter: "+meter);
            Console.WriteLine("In Kilometer: "+kilometer);
        }
    }
}
