using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.May17
{
    internal class FirstProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hii.. My name is Dattaprasad..");
            int a = 5, b = 4, c = 3;
            Console.WriteLine(a++ + b * ++c);
            Console.WriteLine("a = "+a+" b="+b+" c="+c);
            Console.WriteLine(b * 5 / a + b++ + b);
            Console.WriteLine("a = " + a + " b=" + b + " c=" + c);

        }
    }

    class Areaof
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select one of the following: ");
            Console.WriteLine("1)Area of Reactangle");
            Console.WriteLine("1)Area of Circle");
            Console.WriteLine("1)Area of Triangle:");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Enter Length: ");
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width: ");
                int w = int.Parse(Console.ReadLine());

                int aor = l * w;
                Console.WriteLine("Area of rectangle is "+aor);
            }
            else if (num == 2)
            {
                float pi = 3.14f;
                Console.WriteLine("Enter Radius: ");
                int r = int.Parse(Console.ReadLine());

                float aoc = pi * (r *r);
                Console.WriteLine("Area of rectangle is " + aoc);
            }
            else if (num == 3)
            {
                Console.WriteLine("Enter Height: ");
                int h = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Base: ");
                int b = int.Parse(Console.ReadLine());

                float aot = (h*b)/2;
                Console.WriteLine("Area of rectangle is " + aot);
            }

        }
    }
    
    class swapNumbers
    {
        static void Main(string[] args)
        {
            int a, b, temp;

            Console.WriteLine("Enter first variable (a): ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second variable (b): ");
            b = int.Parse(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swapping : ");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }

    class swapNumbers2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first variable (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second variable (b): ");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a="+a+"  b="+b );
        }
    }

    class percentagePerSub
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks of 5 subjects: ");
            Console.WriteLine("English: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Mathematics: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Physics: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Chemistry: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Biology: ");
            int e = int.Parse(Console.ReadLine());
            int total = a + b + c + d + e;
            float per = (total * 100) / 500;
            if((a>=1 && a<=100) && (b>=1 && b<=100) &&(c>=1 && c<=100) && (d>=1 && d<=100) && (e>=1 && e <= 100))
            {
                Console.WriteLine("Your percentage are: " + per);
            }
            else
            {
                Console.WriteLine("Invalid input:");
            }

        }
    }
}
