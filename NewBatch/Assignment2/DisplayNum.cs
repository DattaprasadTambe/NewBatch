using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Assignment2
{
    internal class DisplayNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 121 to 229");
            for(int i = 121; i<=229; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
    class DisplayNum2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 121 to 229");
            for (int i = 521; i >= 229; i--)
            {
                Console.WriteLine(i);
            }
        }

    }

    class breakStmt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break statement");
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                    break;
            }
        }
    }

    class GCD_LCM
    {
        static void Main(string[] args)
        {
            int temp, LCM, GCD, n1, n2;
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number: ");
            int num2 = int.Parse(Console.ReadLine());

            n1 = num1;
            n2 = num2;
            while (n2 != 0)
            {
                temp = n2;
                n2 = n1 % n2;
                n1 = temp;
            }

            GCD = n1;
            LCM = (num1 * num2) / GCD;

            Console.WriteLine("LCM: " + num1, +num2, +LCM);
            Console.WriteLine("GCD: " + num1, +num2, +GCD);
        }

    }

    class displayAlphabates 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display alphabates from a to z: ");
            for(char ch = 'a'; ch<='z'; ch++)
                Console.WriteLine(ch);
        }
    }

    class sumOfEvenNumbers
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter any number: ");
            int n= int.Parse(Console.ReadLine());
            for(int i=0; i<=n; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            Console.WriteLine("Sum of "+n+" even numbers is: "+sum);
        }
    }

    class sumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter any number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                    sum += i;
            }
            Console.WriteLine("Sum of " + n + " odd numbers is: " + sum);
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

    class productOfDigit
    {
        static void Main(string[] args)
        {
            int product = 1, rem = 0;
            Console.WriteLine("Enter any number:");
            int a = int.Parse(Console.ReadLine());

            while (a != 0)
            {
                rem = a % 10;
                a = a / 10;
                product = product * rem;
            }

            Console.WriteLine("Product of digits are: " + product);
        }
    }

    class frequencyOfDigit
    {
        static void Main(string[] args)
        {
            int rem = 0, count = 0;
            Console.WriteLine("Enter any number: ");
            int a= int.Parse(Console.ReadLine());
            int num = a;

            for(int i = 1; i<=9; i++)
            {
                
                
            }
            Console.WriteLine("Frequency of  in " + num + " is : " + count);

        }
    }

    class primeNos
    {
        static void Main(string[] args)
        {
            int ctr ;

            Console.WriteLine("Prime numbers from 400 to 300 are: ");
            for (int i = 400; i >= 300; i--)
            {
                ctr = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && i != 1)
                    Console.WriteLine(i);
            }
        }
    }

    class tableOfGivenNumber
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter any number: ");
            int a = int.Parse(Console.ReadLine());
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(a+" * "+i+" = "+(a*i));
            }
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

    class primeSeries
    {
        static void Main(string[] args)
        {
            Boolean prime;
           
            Console.WriteLine("Prime numbers from 100 to 1:");
            for(int i = 100; i >= 2; i--)
            {
                
                prime = true;
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }

                }
                if (prime)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }

    class sumOfFactorail
    {
        static void Main(string[] args)
        {
            int  f = 1, num, sum=0;
            Console.Write("Enter the number : ");
            num = int.Parse(Console.ReadLine());
            int a = num;
            for (int i = num; i >= 1; i--)
            {
                for(int j = 1; j<=i; j++)
                {
                    f = f * j;
                    
                }
                sum = sum + f;
            }
            Console.Write("Thes sum of Factorials of "+sum);
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

    

}
