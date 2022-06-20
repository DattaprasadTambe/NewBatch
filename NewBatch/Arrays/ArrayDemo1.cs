using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Arrays
{
    internal class ArrayDemo1
    {
    }

    class EvenArrayElements
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter length of an Array: ");
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];

            Console.WriteLine("Enter array elements: ");
            for(int i = 0; i < a.Length; i++)
            {
                int e = int.Parse(Console.ReadLine());
                a[i] = e;   
            }
            Console.WriteLine("Array elements are: ");
            foreach(int ele in a)
            {
                Console.Write(ele+"  ");
            }
            Console.WriteLine();
            Console.WriteLine("Even elements from array: ");
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i]+"  ");
                }
            }
        }
    }

    class OddPositionElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of an Array: ");
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];

            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < a.Length; i++)
            {
                int e = int.Parse(Console.ReadLine());
                a[i] = e;
            }
            Console.WriteLine("Array elements are: ");
            foreach (int ele in a)
            {
                Console.Write(ele + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Odd position elements are: ");
            for(int i =0; i < a.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(a[i]);
                    
                }
                else
                {
                    continue;
                }
               
            }
        }

    }

    class AlternateArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of an Array: ");
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];

            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < a.Length; i++)
            {
                int e = int.Parse(Console.ReadLine());
                a[i] = e;
            }
            Console.WriteLine("Array elements are: ");
            foreach (int ele in a)
            {
                Console.Write(ele + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Alternate array elements are: ");
            for(int i=0; i < a.Length; i =i+ 2)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
