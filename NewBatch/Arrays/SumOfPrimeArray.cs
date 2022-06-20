using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Arrays
{
    internal class SumOfPrimeArray
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = { 2, 6, 3, 9, 15, 7, 20, 23, 33 };
            Console.WriteLine(string.Join(" ",arr));
            for(int i=0; i<arr.Length; i++)
            {
                int n = arr[i];
                bool isPrime = true;
                for(int j=2; j<n/2; j++)
                {
                    if (n % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine("Array elements are: " + arr[i]);
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine("Sum of prime elements in array is: " + sum);

        }
    }

    class AvgOfOddNumbers
    {
        static void Main(string[] args)
        {
            int sum=0, avg, count = 0;
            int[] a = { 2, 7, 3, 5, 18, 17, 23, 30 };
            Console.WriteLine(String.Join(" ",a));
            Console.WriteLine("Odd elements are: ");
            for (int i=0; i<a.Length; i++)
            {
                
                if (a[i] % 2 != 0)
                {
                    Console.WriteLine(a[i]);
                    sum = sum+a[i];
                    count++;
                }
            }
            Console.WriteLine("Some of odd elements is: "+sum);
            avg = sum/count;
            Console.WriteLine("Average of Odd elements is: "+avg);
        }
    }

    class ReverseArray
    {
        static void Main(string[] args)
        {
            char[] ch = { 'v', 'c', 't', 'b', 'd', 'z', 'g' };
            Console.WriteLine(String.Join(" ",ch));
            int j = ch.Length - 1;
            for (int i = 0; i <= ch.Length / 2; i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j]= temp;
                j--;
            }
            Console.WriteLine(String.Join(" ",ch));
        }
    }

    class MaxElement 
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 3, 6, 4, 1, 9, 2 };
            Console.WriteLine(String.Join(" ", arr));
            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max element is: "+max);

        }
    }

    class MinElement
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 3, 6, 4, 1, 9, 2 };
            Console.WriteLine(String.Join(" ", arr));
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min element is: " + min);

        }
    }

}
