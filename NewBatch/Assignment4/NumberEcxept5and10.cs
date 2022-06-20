using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Assignment4
{
    internal class NumberEcxept5and10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers between 1 to 100 except 5 and 10: ");
            for(int i=1; i<=100; i++)
            {
                if(i % 5 != 0 && i % 10 != 0)
                {
                    Console.WriteLine(i);
                    
                }
                else
                {
                    continue;
                }
                
            }
        }
    }

    class Loop
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            } while (b != 3);
        }
    }

    class Loop2
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("K ="+k+" I="+i);
        }
    }

    class SpyNumber
    {
        static void Main(string[] args)
        {
            int sum = 0, mul = 1, mod, temp;
            Console.WriteLine("Enter any number:");
            int a = int.Parse(Console.ReadLine());
            temp = a;
            while (a != 0)
            {
                mod = a % 10;
                sum = sum + mod;
                mul = mul * mod;
                a /= 10;
            }
            Console.WriteLine("Sum ="+sum);
            Console.WriteLine("Multiplication ="+mul);
            if(sum == mul)
            {
                Console.WriteLine(temp + " is Spy Number..");
            }
            else
                Console.WriteLine(temp+" is not a Spy Number..");
        }
    }

    class TrimorphicNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int a = int.Parse(Console.ReadLine());

            int cube = a * a * a;
            int mod = cube % 10;
            Console.WriteLine("Cube = "+cube);
            if (mod == a)
            {
                Console.WriteLine(a+" is a trimorphic number..");
            }
            else
            {
                Console.WriteLine(a+" is not a trimorphic number..");
            }
        }
    }

    class pattern1
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine("");
            }
        }
    }

    class pattern2
    {
        public static void Main(String[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
               for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 6-i; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }

        }
    }

    class pattern4
    {
        public static void Main(String[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int k = 1; k <= 6 -i; k++)
                {
                    Console.Write("  ");
                }
                for (int j = 2; j <= i+i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            
        }
    }

    class pattern3
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=5; i++)
            {
                for (int k = 5; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }
                
                Console.WriteLine();
            }
        }
        
    }

    class Loop3
    {
        static void Main(string[] args)
        {
            
            for (int i=5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }
        }
    }

    class TwinPrimeNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two Number : ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            if (num1 == 0 || num1 == 1 && num2 == 0 || num2 == 1)
            {
                Console.WriteLine("Is not a prime number");
            }
            if (num1 == 2 && num2 == 2)
            {
                Console.WriteLine("Is a prime number");
            }
            for (int i = 2; i <= num1/2; i++)
            {
                if (num1 % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    break;
                }
                else
                    Console.WriteLine("prime");
                break;

            }
            for (int i = 2; i <= num2 / 2; i++)
            {
                if (num2 % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    break;
                }
                else
                    Console.WriteLine("prime");
                break;

            }


        }
    }

    class whileSeries
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
                Console.WriteLine(sq + cube);
                i++;
            }
        }
    }

    class NumFrom1to50
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=50; i++)
            {
                if( i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("Negative Number - " + (i * i));
                }
            }
        }
    }

    class pridict
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }
        }
    }

    class fibbonacciSeries
    {
        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, num;
            Console.Write("Enter the number of elements: ");
            num = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); 
            for (i = 2; i < num; i++)   
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }

    class sumOfFactorail
    {
        static void Main(string[] args)
        {
            int num, sum = 0, i=1;
            Console.Write("Enter the number : ");
            num = int.Parse(Console.ReadLine());
            
            while(i <= num)
            {
                int fact = 1, j=1;
                while (j <= i)
                {
                    fact *= j;
                    j++;
                }
                sum = sum + fact;
                
                i++;
            }
           
            Console.WriteLine("The sum of Factorials : " + sum);
        }
        
    }

    class OneToTen
    {
        static void Main(string[] args)
        {
            int i, s = 0;
            for (i = 1; i <= 10;  i++)
            {
                s = s + i;
            }
            Console.WriteLine(s);
        }
    }

    class QueOne
    {
        static void Main(string[] args)
        {
            int i;
            for(i =-3; i<=3; i++)
            {
                switch (i)
                {
                    case 0: Console.WriteLine("Zero");
                        break;
                    if (i > 0)
                        {
                            Console.WriteLine("A");
                        }
                    else if (i < 0)
                        {
                            Console.WriteLine("B");
                        }
                }
            }
        }
    }
}
