using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.May27
{
    internal class Pattern1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern3
    {
        static void Main(string[] args)
        {
            int value=1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(value +" ");

                    value++;
                }

                Console.WriteLine( );
            }
        }
    }

    class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || i == 5 || j == 1 || j == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }

    class primeNosSum
    {
        static void Main(string[] args)
        {
            int ctr, sum=0;

            Console.WriteLine("Prime numbers from 1 to 10 are: ");
            for (int i = 1; i <= 10; i++)
            {
                ctr = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        ctr++;
                        
                        break;
                    }
                    sum = sum + i;
                }
                
                
                if (ctr == 0 && i != 1)
                    Console.WriteLine(i);
                
            }
            Console.WriteLine("Sum of prime numbers is: " + sum);
        }
    }
}
