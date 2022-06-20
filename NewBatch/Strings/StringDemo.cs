using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Strings
{
    internal class StringDemo
    {
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
            Console.WriteLine("Numbers of words in string are: "+count);

        }
        
    }

    class StringPattern
    {
        static void Main(string[] args)
        {
            String str = "My name is Dattaprasad";
            Console.WriteLine(str);
            string[] str1 = str.Split();
            for(int i=0; i<str1.Length ; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write(str1[j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
