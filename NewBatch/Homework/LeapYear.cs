using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Homework
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());

            if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
            {
                Console.WriteLine(Year + " is a Leap Year..");
            }
            else
            {
                Console.WriteLine(Year + " is not a Leap Year..");

            }

        }
    }

    class Divisibleby5and11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int a = int.Parse(Console.ReadLine());

            if (a % 5 == 0 && a % 11 == 0)
            {
                Console.WriteLine(a + " is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine(a + " is not divisible by 5 and 11");
            }
        }
    }

    class MaxBetweenThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any 3 numbers: ");
            Console.WriteLine("First: ");
            int a = int.Parse((Console.ReadLine()));
            Console.WriteLine("Second: ");
            int b = int.Parse((Console.ReadLine()));
            Console.WriteLine("Third: ");
            int c = int.Parse((Console.ReadLine()));

            if (a > b && a > c)
            {
                Console.WriteLine(a + " is max number..");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " is max number..");
            }

            else if (c > a && c > b)
            {
                Console.WriteLine(c + " is max number..");
            }
            else
            {
                Console.WriteLine("All numbers are equal");
            }

        }
    }

    class VowelOrConsonent
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = char.Parse(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel.");

            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant.");
            }
            else
            {
                Console.WriteLine("Invalid input..");
            }
        }
    }

    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st input");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");
            int action = int.Parse(Console.ReadLine());

            int result = 0;
            if (action == 1)
            {
                result = num1 + num2;
                Console.WriteLine("Addition: " + result);
            }
            else if (action == 2)
            {
                result = num1 - num2;
                Console.WriteLine("Subtraction: " + result);
            }
            else if (action == 3)
            {
                result = num1 * num2;
                Console.WriteLine("Multiplication: " + result);
            }
            else if (action == 4)
            {
                result = num1 / num2;
                Console.WriteLine("Division: " + result);
            }
            else
            {
                Console.WriteLine("Invalid Input:");
            }

        }
    }

    class PosNegZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine(a + " is positive number..");
            }
            else if (a < 0)
            {
                Console.WriteLine(a + " is negative number..");
            }
            else
            {
                Console.WriteLine(a + " equals zero..");
            }
        }
    }

    class charCheck
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = char.Parse(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is an Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + " is a Digit. ");
            }
            else
            {
                Console.WriteLine(ch + " is a Special character.. ");
            }
        }
    }

    class grossSalary
    {
        static void Main(string[] args)
        {
            float Basic_Salary, DA, HRA, Gross_Salary;

            Console.WriteLine("Enter Basic Salary : ");
            Basic_Salary = float.Parse(Console.ReadLine());

            if (Basic_Salary <= 10000)
            {
                HRA = (Basic_Salary * 20) / 100;
                DA = (Basic_Salary * 80) / 100;

            }
            else if (Basic_Salary <= 20000)
            {
                HRA = (Basic_Salary * 25) / 100;
                DA = (Basic_Salary * 90) / 100;

            }
            else
            {
                HRA = (Basic_Salary * 30) / 100;
                DA = (Basic_Salary * 95) / 100;



            }
            Gross_Salary = Basic_Salary + DA + HRA;
            Console.WriteLine("HRA 30% of Basic Salary : " + HRA);
            Console.WriteLine("DA 95% of Basic Salary : " + DA);
            Console.WriteLine("Gross Salary : " + Gross_Salary);
        }

    }

    class threeDigitNumber
    {
        static void Main(string[] args)
        {
            int sum;

            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            if (a >= 100 && a <= 999 || a >= -999 && a <= -100)
            {
                Console.WriteLine(a + " is a 3 digit number..");

                int div = a / 100;
                int mod = a % 10;

                sum = div + mod;

                Console.WriteLine("Sum of digits is: " + sum);


            }
            else
            {
                Console.WriteLine(a + " is not a three digit number..");
            }
        }
    }

    class dayOfWeek
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

    class numOnetoFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("ONE");
            }
            else if (a == 2)
            {
                Console.WriteLine("TWO");
            }
            else if (a == 3)
            {
                Console.WriteLine("THREE");
            }
            else if (a == 4)
            {
                Console.WriteLine("FOUR");
            }
            else if (a == 5)
            {
                Console.WriteLine("FIVE");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }

    class Area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the following:");
            Console.WriteLine("1) Area of Circle: ");
            Console.WriteLine("2) Area of Square: ");
            Console.WriteLine("3) Area of Right Angled Traingle: ");
            Console.WriteLine("4) Area of Rectangle: ");
            Console.WriteLine("5) Circumferance of Circle: ");
            Console.WriteLine();
            Console.Write("You have selected:");
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                float pi = 3.14f;
                Console.Write("Enter the radius: ");
                int r = int.Parse(Console.ReadLine());

                float aoc = pi * (r * r);
                Console.Write("Area of circle is: " + aoc);

            }
            else if (a == 2)
            {
                Console.Write("Enter the Length of side: ");
                int l = int.Parse(Console.ReadLine());


                int aos = l * l;
                Console.WriteLine("Area of Square is: " + aos);

            }
            else if (a == 3)
            {
                Console.Write("Enter the height: ");
                int h = int.Parse(Console.ReadLine());

                Console.Write("Enter the width: ");
                int w = int.Parse(Console.ReadLine());


                int aorat = (h * w) / 2;
                Console.Write("Area of Right Angled Triangle is: " + aorat);

            }
            else if (a == 4)
            {
                Console.Write("Enter the length: ");
                int len = int.Parse(Console.ReadLine());

                Console.Write("Enter the breadth: ");
                int bre = int.Parse(Console.ReadLine());


                int aorect = len * bre;
                Console.Write("Area of rectangle is: " + aorect);

            }
            else if (a == 5)
            {
                float pi = 3.14f;

                Console.Write("Enter the radius: ");
                int r = int.Parse(Console.ReadLine());

                float coc = 2 * pi * r;
                Console.Write("Circumferance of circle is: " + coc);

            }
            else
            {
                Console.Write(" Error!! Invalid Input..");
            }

        }
    }
    class denomination
    {
        static void Main(string[] args)
        {
            int rs, a, b, c, d, e, f, g, h;
            Console.WriteLine("Enter the amount in Rupees : ");
            rs = int.Parse(Console.ReadLine());

            while (rs >= 2000)
            {
                a = rs / 2000;
                rs = rs % 2000;
                Console.WriteLine("The no. of 2000Rs notes are :" + a);
                break;
            }
            while (rs >= 500)
            {
                b = rs / 500;
                rs = rs % 500;

                Console.WriteLine("The no. of 500Rs notes are :"+b);
                break;
            }
            while (rs >= 200)
            {
                c = rs / 200;
                rs = rs % 200;
                Console.WriteLine("The no. of 200Rs notes are :" + c);
                break;
            }
            while (rs >= 100)
            {
                d = rs / 100;
                rs = rs % 100;
                Console.WriteLine("The no. of 100Rs notes are :" + d);
                break;
            }
            while (rs >= 50)
            {
                e = rs / 50;
                rs = rs % 50;
                Console.WriteLine("The no. of 50Rs notes are :" + e);
                break;
            }
            while (rs >= 20)
            {
                f = rs / 20;
                rs = rs % 20;
                Console.WriteLine("The no. of 20Rs notes are :" + f);
                break;
            }
            while (rs >= 10)
            {
                g = rs / 10;
                rs = rs % 10;
                Console.WriteLine("The no. of 10Rs notes are :" + g);
                break;
            }
            while (rs >= 5)
            {
                h = rs / 5;
                rs = rs % 5;
                Console.WriteLine("The no. of 5 Rs coins are :" + h);
                break;
            }
            while (rs >= 2)
            {
                int i = rs / 2;
                rs = rs % 2;
                Console.WriteLine("The no. of 2 Rs coins : " + i);
                break;
            }
            while (rs >= 1)
            {
                int j = rs / 1;
                rs = rs % 1;
                Console.WriteLine("The no. of 1 Rs coins : " + j);
                break;
            }
        }
    }





    class displaynumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Numbers from 35 to75:");
            for (int i = 35; i <= 75; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Numbers from 125 to 85:");
            for (int i = 125; i >= 85; i--)
            {
                Console.WriteLine(i);
            }
        }
    }

    class oddnumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers between 25 to 45: ");
            for(int i = 25; i<=45; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class OddNumberCount
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Count of odd numbers between 1 to 20: ");
            for(int i=1;i<=20; i++)
            {
                if(i%2!=0)
                    count++;    
            }
            Console.WriteLine(count);

        }
    }

    class indexandbase
    {
        static void Main(string[] args)
        {
            int baseno, index, power = 1;

            Console.Write("Enter base number: ");
            baseno = int.Parse(Console.ReadLine());

            Console.Write("Enter index number: ");
            index = int.Parse(Console.ReadLine());

            while (index >= 1)
            {
                power = power * baseno;
                index--;
            }
            Console.Write("Power : " + power);
        }

    }

    class factorsOfNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int a = int.Parse(Console.ReadLine());
            int sum=0;
            Console.WriteLine("Factors are: ");
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of factors: "+sum);

        }
    }

    class tableofNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to print table:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Table of " + n + " is:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n * i);
            }

        }
    }
}
