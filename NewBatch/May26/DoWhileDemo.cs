using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.May26
{
    internal class DoWhileDemo
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i > 10);

        }
        

    }

    class calculator
    {
        static void Main(string[] args)
        {
            int ch = Console.ReadLine()[0];
            do
            {

            }while (ch == 'y'||ch=='Y');
        }
    }

    class nestedLoop 
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1; i <= 5; i++)
            {
                int fact = 1;
                for(int j=1; j <= i; j++)
                {
                    fact = fact * j;
                }
                sum = sum + fact;
            }
            Console.WriteLine(sum);
        }
    }

    class pattern1
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j =1; j<=4; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    class pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    class pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    class pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }

    class pattern5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class table1to5
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=5; i++)
            {
                Console.WriteLine("Table of "+i);
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i*j);
                }
                Console.WriteLine();
            }
        }
    }

    class trimorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number to check if is Trimorphic:");
            int a = int.Parse(Console.ReadLine());

            int cube = a * a * a;
            Console.WriteLine("Cube of " + a + " is:" + cube);
            int c = cube % 10;

            if (a == c)
            {
                Console.WriteLine(a + " is timporphic..");
            }
            else
            {
                Console.WriteLine(a + " is not timporphic..");

            }
        }
    }

    class disariumNo
    {
        public static void Main(string[] args)
        {
            int r, sum = 1, temp, count=1,ctr, add=0, div=0, num=1;
            Console.Write("Enter the Number= ");
            int n = int.Parse(Console.ReadLine());
            temp = n;
            ctr = count;
            while (n >= 10)
            {
                n = n / 10;
                count++;
            }
            int c = count;
            Console.WriteLine(count);
            n = temp;
            while(n != 0)
            {
                r = n % 10;
                Console.WriteLine(r);
                for (; ctr <= count; ctr++)
                {
                    sum = sum*r;
                    Console.WriteLine(sum);
                    
                }
                
                count --;
                Console.WriteLine(count);
                n = n / 10;
                Console.WriteLine(n);
            }
            int summ = sum;
            sum = 1;
            add = add + summ;
            Console.WriteLine(add);
            if (temp == sum)
                Console.Write(temp + " is an disarium Number.");
            else
                Console.Write(temp + " Not an disarium Number.");
        }
    }
    
    class automorphicNo
    {
        static void Main(string[] args)
        {
            int flag = 1;
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            int sqr = num * num;
            while (num > 0)
            {
                if (num % 10 != sqr % 10)
                    flag = 0;
           
                num /= 10;
                sqr /= 10;
            }
            

            if (flag == 0)
            {
                Console.WriteLine("Not an Automorphic number..");
            }
            else
            {
                Console.WriteLine("Automorphic number..");
            }
        }
    }
}
