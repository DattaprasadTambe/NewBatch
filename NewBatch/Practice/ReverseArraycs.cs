using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Practice
{
    internal class ReverseArraycs
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 7, 9, 2, 8, 1, 6 };
            Console.WriteLine("Array elements: " + String.Join(" ", a));
            int j = a.Length - 1;
            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine("Array after reverse: " + String.Join(" ", a));
        }
    }

    class StringReverse
    {
        static void Main(string[] args)
        {
            string name = "Dattaprasad";
            char[] c = name.ToCharArray();
            int j = c.Length - 1;
            for (int i = 0; i < c.Length / 2; i++)
            {
                char ch = c[i];
                c[i] = c[j];
                c[j] = ch;
                j--;
            }
            Console.WriteLine(name);
            Console.WriteLine(String.Join(" ", c));
        }
    }

    class StringPalindrome
    {
        static void Main(string[] args)
        {
            string s = "radar";
            bool isPalindrome = true;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome == true)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }
    }

    class StringOccurance
    {
        static void Main(string[] args)
        {
            string name = "Dattaprasad";
            string name1 = name.ToLower();
            char[] a = name1.ToCharArray();
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
                    Console.WriteLine(a[i] + " " + count);
                }
            }
        }
    }


    class DuplicateStringRemove
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string s1 = "Dattaprasad";
            string s2 = "prasad";
            Console.WriteLine(s1+"\n"+s2);
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();
            string s = " ";
            for(int i=0; i < c1.Length; i++)
            {
                for (int j = 0; j < c2.Length; j++)
                {
                    if (c1[i] == c2[j])
                    {
                        break;
                    }
                    else
                    {
                        s = s + c1[i];
                    }
                }
                
               
            }
            Console.WriteLine(s);


        }
    }
}