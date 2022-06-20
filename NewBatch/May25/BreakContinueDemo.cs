using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.May25
{
    internal class BreakContinueDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hii");
        }
    }

    class displaynumusingWhile
    {
        static void Main(string[] args)
        {
            int i = 85;
            while (i >= 25)
            {
                Console.Write("\t"+i);
                i--;
            }
        }
    }

    class whileSeries
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Enter any number: ");
            int n = int.Parse(Console.ReadLine());
            while (i <= n)
            {

                if (i % 2 != 0)
                {
                    int a = (i * i);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(i);
                }
                
                i++;
            }
        }
    }

    class whileSeries2
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.Write("Enter any number: ");
            int n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                int sq = i * i;
                int cube = i * i * i;
                Console.WriteLine(sq+cube);
                i++;
            }
        }
    }

    class spyNumber
    {
        static void Main(string[] args)
        {
            int add = 0, mul = 1;
            int n = int.Parse(Console.ReadLine());
            int num = n;
            while (n != 0)
            {
                int rem = n % 10;
                add = add + rem;
                mul = mul * rem;
                n = n / 10;
            }
            if(add == mul)
            {
                Console.WriteLine(num+" is a spy number..");
            }
            else
                Console.WriteLine(num+" is not a spy number..");
        }
    }

    class countOfDigit
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter any number:");
            int a = int.Parse(Console.ReadLine());

            while (a != 0)
            {
                a = a / 10;
                count++;
            }

            Console.WriteLine("Number of digits are: " + count);
        }
    }
    class palindromeNo
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0, temp;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                sum = sum * 10 + rem;

            }
            Console.WriteLine("The Reversed Number is:", +sum);
            if (temp == sum)
            {
                Console.WriteLine("Number is Palindrome ");
            }
            else
            {
                Console.WriteLine("Number is not a palindrome ");
            }
            Console.ReadLine();
        }
    }
    class ArmstrongNumber
    {
        public static void Main(string[] args)
        {
            int r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            int n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write(temp+" is an Armstrong Number.");
            else
                Console.Write(temp+" Not an Armstrong Number.");
        }
    }

    class SumofDigit
    {
        static void Main(string[] args)
        {
            int sum, last, first=1;

            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            last = a % 10;
            
            while (a >= 10) {
                a = a / 10;
                
            }
            sum = a + last;
            Console.WriteLine("First digit: "+a);
            Console.WriteLine("Last digit: " + last);
            Console.WriteLine("Sum of digits is: " + sum);
        }
    }
}
