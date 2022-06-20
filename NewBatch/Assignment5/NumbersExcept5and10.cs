using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Assignment5
{
    internal class NumbersExcept5and10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 1 to 100 except numbers which are divisible by 5 and 10:");
            for(int i=1; i<=100; i++)
            {
                if(i%5 ==0 && i % 10 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class FactorsOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number to find factors of it: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factors of "+n+" : ");
            for(int i = 1; i<=n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class SquareOfOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 1 to 50 with Even numbers as it is and Odd numbers with its square: ");
            for(int i =1; i<=50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i*i);
                }
            }
        }
    }

    class FiboSeries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibo series up to 20 terms: ");
            int n1 = 0, n2 = 1, n3;
            Console.WriteLine(n1+"\n"+n2);
            for(int i = 3; i<=20; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }

    class HarshadNumber
    {
        static void Main(string[] args)
        {
            int rem=0, sum=0;
            Console.WriteLine("Enter a number to check if it is Harshad Number or not: ");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            while (n != 0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            Console.WriteLine("Sum of digits of "+temp+" is : "+sum);
            if(temp % sum == 0)
            {
                Console.WriteLine(temp+" is a Harshad Number..");
            }
            else
            {
                Console.WriteLine(temp+" is not a Harshad Number..");
            }
           
        }
    }

    class FactorOf3and5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 1 to 100: ");
            for (int i = 1; i <= 100; i++)
            {
                if(i%3 ==0 && i % 5 == 0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Red");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Blue");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }

    class Krishnamurthy
    {
        static void Main(string[] args)
        {
            int rem = 0, sum=0, fact , temp;
            Console.WriteLine("Enter a number to find if it is a Krishnamurthy Number or not: ");
            int n = int.Parse(Console.ReadLine());
            temp = n;
            while (n != 0)
            {
                fact = 1;
                rem = n % 10;
                for( int i =rem; i>=1; i--)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                n /= 10;
            }
            Console.WriteLine("Sum of Factorials of Factors: "+sum);
            if(temp == sum)
            {
                Console.WriteLine(temp+" is a Krishnamurthy Number...");
            }
            else
            {
                Console.WriteLine(temp+" is not a Krishnamurthy Number...");
            }
        }
    }

    class palindrome
    {
        static void Main(string[] args)
        {
            int rev = 0, rem=0, temp;
            int n = int.Parse(Console.ReadLine());
            temp = n;
            while (n != 0)
            {
                rem = n % 10;
                rev = (rev * 10) + rem;
                n = n / 10;
            }
            if(temp == rev)
            {
                Console.WriteLine("palindrom");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }

    class DigitAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rem = 0,sum=0, temp, count=0;
            double avg;
            temp = n;
            while (n != 0)
            {
                rem = n % 10;
                sum = sum + rem;
                count++;
                n = n / 10;
            }
            avg = (double) (sum / count);
            Console.WriteLine(avg);
        }
    }

    class abc
    {
        public static void a()
        {
            Console.WriteLine( "First method");
        }
        public void b()
        {
            a();
            Console.WriteLine("second method");
        }
        public void b(int i)
        {
            Console.WriteLine(i);
            b();
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            abc k = new abc();
            abc.a();
            k.b(20);
        }
    }
}
