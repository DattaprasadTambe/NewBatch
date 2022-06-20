using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.StringTest
{
    internal class DuplicateWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            char[] a = s.ToCharArray();
            Console.WriteLine();
            Console.WriteLine("Duplicate elements are: ");
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
                        Console.WriteLine(a[i]+" occured "+count);
                    }
                }
            }
        }
    }

    class NoOfWords
    {
        static void Main(string[] args)
        {
            String str = "My name is Dattaprasad";
            Console.WriteLine(str);
            string[] str1 = str.Split();
            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                count++;
            }
            Console.WriteLine("Numbers of words in string are: " + count);

        }
    }
    class Anagram
    {
         static void Main()
        {
            string str1 = "silent";
            string str2 = "listen";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
        }
    }

    class TotalsinString
    {
        static void Main(string[] args)
        {
            string str = "Dattaprasad@21";
            char[] ch = str.ToLower().ToCharArray();
            int alpha = 0, num = 0, spec = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if(ch[i]>='a' && ch[i] <= 'z')
                {
                    alpha++;
                }
                else if(ch[i]>='0' && ch[i] <= '9')
                {
                    num++;
                }
                else
                {
                    spec++;
                }
            }
            Console.WriteLine("Number of Alphabates: "+alpha);
            Console.WriteLine("Number of Numbers: "+num);
            Console.WriteLine("Number of Secial Characters: "+spec);
        }
    }

    class SortStringArray
    {
        static void Main(string[] args)
        {
            string[] str = { "Goku", "Vegeta", "Naruto", "Madara", "Itachi","Sukuna","Marin","Akeno","Gojo","Bakugo" };
           
            Console.WriteLine("Array before sorting: \n"+String.Join("\n",str));

            for(int i=0; i<str.Length-1; i++)
            {
                for (int j = i + 1; j< str.Length; j++)
                {
                    if (str[i].CompareTo(str[j]) < 0)
                    {
                        string temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                }
                
            }
            Console.WriteLine("Array after sorting: \n"+String.Join("\n",str));
        }
    }

    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int i=0,j=arr.Length-1-i; i<arr.Length/2; i++)
            {
                arr[i] = arr[j];
                Console.WriteLine(arr[i]);
            }
            
        }
    }

    class MergeArray
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 5, 2, 34, 7, 5 };
            int[] a2 = { 1, 7, 8, 9, 4, 5 };
            int[] a3 = new int[a1.Length + a2.Length];
            int[] temp = new int[a3.Length];
            for(int i=0; i<a1.Length; i++)
            {
                a3[i] = a1[i];
            }
            for (int j1 = 0, k = a1.Length; k < a3.Length && j1 < a2.Length; j1++, k++)
            {
                a3[k] = a2[j1];
            }
            Console.WriteLine("Array after combining: " + String.Join(" ", a3));
            int j = 0;
            for (int i = 0; i < a3.Length-1; i++)
            {
                if (a3[i] != a3[i + 1])
                {
                    temp[j++]=a3[i];
                }
                
            }
            Console.WriteLine(String.Join(" ",temp));
            temp[j++] = a3[a3.Length - 1];
            for(int k = 0; k < j; k++)
            {
                Console.WriteLine(temp[k]);
            }
            
        }
    }

    class ArraySort
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 5, 2, 1, 6, 9, 4, };
            Console.WriteLine("Array elements are: \n"+String.Join(" ",a));
            int temp;
            for(int i=0;i<a.Length; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array elements after sorting: \n" + String.Join(" ", a));

        }
    }

    class Swap0wih1
    {
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 10, 0, 34 };
            Console.WriteLine("Array elements are: "+String.Join(" ",a));

            for(int i=0; i<a.Length; i++)
            {
                if (a[i] == 0)
                {
                    a[i] = 1;
                }
            }
            Console.WriteLine("Array after replacing 0 with 1: "+String.Join(" ",a));
        }
    }

    class ReplaceNegative
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            Console.WriteLine("Array elements are: " + String.Join(" ", a));

            for(int i=0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    a[i] = a[i - 1] * a[i - 1];
                }
            }
            Console.WriteLine("Array elements after replacing negatice values with its immediate left elements square: "+String.Join(" ",a));
        }
    }

    class MinCharacter
    {
        static void Main(string[] args)
        {
            char[] ch = { 'A', 'D', 'E', 'x', 'z', 'R' };
            Console.WriteLine("Array elements are: "+String.Join(" ",ch));
            char min = ch[0];
            for(int i=0; i<ch.Length-1; i++)
            {
                if (ch[i]<=min)
                {
                    min = ch[i];
                }
                
            }
            Console.WriteLine("Minimun character in array is: "+min);
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



    class SumOFNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers to perform addition: ");
            Console.WriteLine("First: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition is: "+(a+b));
            Console.WriteLine("Subtraction is: "+(a-b));
            Console.WriteLine("Multiplication is: "+(a*b));
            Console.WriteLine("Division is: "+(float)(a/b));

        }
    }

    class AOR
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght and breadth to find the area of rectangle: ");
            Console.WriteLine("Enter Length: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth: ");
            int b = int.Parse(Console.ReadLine());

            int aor = l * b;
            Console.WriteLine("Area of rectangle : "+aor);
        }
    }

    class AOT
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Base: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height: ");
            int h = int.Parse(Console.ReadLine());

            int aot = (b*h)/2;
            Console.WriteLine("Area of triangle : " + aot);
        }
    }

    class SquareOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            int sqr = a * a;
            Console.WriteLine("Squaare of " + a + " is: " + sqr);
        }
    }

    class CubeOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            int cube = a * a * a;
            Console.WriteLine("Squaare of " + a + " is: " + cube);
        }
    }

    class ConvertDistance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance in Kilometer: ");
            float cm = float.Parse(Console.ReadLine());

            float meter = cm / 100;
            float km = cm / 100000;
            Console.WriteLine(cm+" in Meter: "+meter);
            Console.WriteLine(km+" in Kilometer: "+km);

        }
    }
}
