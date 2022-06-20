using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Arrays
{
    internal class Occurance
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 8, 2, 2, 9, 5, 8, 4, 2 };
            Console.WriteLine(String.Join(" ",a));

            Console.WriteLine();
            Console.WriteLine("Number of each element occured: ");
            for(int i = 0; i<a.Length; i++)
            {
                int count = 1;
                bool isVisited = false;
                for(int k=i-1; k>=0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for(int j=i+1; j<a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i]+" "+count);
                }
            }
        }
    }

    class GivenEleOccurance
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 8, 2, 2, 9, 5, 8, 4, 2 };
            Console.WriteLine(String.Join(" ", a));

            Console.WriteLine("Enter an element to find its occurance: ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
               if(n== a[i])
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(n+" occured "+count+" times");

        }
    }

    class UniqueElements
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 8, 2, 2, 9, 5, 8, 4, 2 };
            Console.WriteLine(String.Join(" ", a));

            Console.WriteLine();
            Console.WriteLine("Unique elements are: ");
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isVisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }

        }
    }

    class DuplicateEle
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 8, 2, 2, 9, 5, 8, 4, 2 };
            Console.WriteLine(String.Join(" ", a));

            Console.WriteLine();
            Console.WriteLine("Unique elements are: ");
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isVisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }

        }
    }

    class MergeArrays
    {
        static void Main(string[] args)
        {
            
            int[] a = { 1, 2, 3, 4,10 };
            int[] b = { 9, 8, 7, 6 };
            int range = a.Length + b.Length;
            int[] c = new int[range];
            Console.WriteLine("First array is: "+String.Join(" ",a));
            Console.WriteLine("Second array is: " + String.Join(" ", b));
            for(int i=0; i < a.Length; i++)
            {
                c[i]= a[i];
            }
            for (int j = 0, k = a.Length; k < range && j < b.Length; j++, k++)
            {
                c[k]= b[j];
            }
            Console.WriteLine("Array after combining: "+String.Join(" ", c));
        }
    }

    class Alternative
    {
        static void Main(string[] args)
        {
            int index1=0, index2=1;
            int[] a = { 1, 2, 3, 4,12 };
            int[] b = { 9, 8, 7, 6 };
            int range = a.Length + b.Length;
            int[] c = new int[range];
            Console.WriteLine("First array is: " + String.Join(" ", a));
            Console.WriteLine("Second array is: " + String.Join(" ", b));
            for (int i = 0; i < a.Length; i++)
            {
                c[index1] = a[i];
                index1 += 2;
            }
            
            for (int i = 0; i < b.Length; i++)
            {
                c[index2] = b[i];
                index2 += 2;
            }
            Console.WriteLine("Array after combining: "+String.Join(" ", c));


        }
    }
    

    class AdditionOfArray
    {
        static void Main(string[] args)
        {
            int[,] a = { { 4, 8 },{ 7, 2 } };
            int[,] b = { { 7, 9 },{ 2, 3 } };
            Console.WriteLine("Array 1:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "    ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Array 2:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + "    ");
                }
                Console.WriteLine();
            }
            
            int[,] result = new int[2,2];
            for(int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j < b.GetLength(1); j++)
                {
                    result[i,j] = a[i, j] + b[i, j];
                }
                
            }
            Console.WriteLine("Afer Addition: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + "    ");
                }
                Console.WriteLine();
            }

        }
    }

    class ArrayPattern
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };
            //for(int)
        }
    }
}
