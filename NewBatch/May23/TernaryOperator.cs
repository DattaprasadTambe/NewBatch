using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.May23
{
    internal class TernaryOperator

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:" );
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number:" );
            int b = int.Parse(Console.ReadLine());

        }

    }

    class evenOrodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            String result = num % 2 == 0 ? " is Even" : "is Odd";
            Console.WriteLine(num+" "+result);

        }
    }

    class simpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("1:Addition \n2:Subtraction \n3:Multiplication \n4:Division");
            Console.WriteLine("Enter your choice:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine("Addition = "+(a+b));
                    break;
                case 2:
                    Console.WriteLine("Subtraction = " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiplication = " + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Division = " + (a / b));
                    break;
                default: Console.WriteLine("Invalid Input..");
                    break;
            }

        }
    }

    class evenoddusingTernary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            String result = (a % 2 == 0) ? "is Even" : "is Odd";
            Console.WriteLine(a+" "+result);
        }
    }

    class greatestBetThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three number: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = (a > b && a > c) ? a : (b > a && b > c) ? b : c;
            Console.WriteLine(result+ " is greatest");
        }
    }

    class greatest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three number: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = a > b ? (a > c ? a : c) : (b > c ? b : c);
            Console.WriteLine(result);
        }
    }
    

    class DayOfWeek
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weekday number (1-7): ");
            int day = int.Parse(Console.ReadLine());

            if (day == 1)
            {
                Console.WriteLine("It's a Sunday");
            }
            else if (day == 2)
            {
                Console.WriteLine("It's a Monday");
            }
            else if (day == 3)
            {
                Console.WriteLine("It's a Tuesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("It's a Wednesday");
            }
            else if (day == 5)
            {
                Console.WriteLine("It's a Thursday");
            }
            else if (day == 6)
            {
                Console.WriteLine("It's a Friday");
            }
            else if (day == 7)
            {
                Console.WriteLine("It's a Saturday");
            }
            else
            {
                Console.WriteLine("Error! Day does not exist");
            }
        }
    }


    class EvenOddusingSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            switch (a % 2)
            {
                case 0: Console.WriteLine("Even");
                    break;
                case 1: Console.WriteLine("Odd");
                    break;
            }
        }
    }
}
