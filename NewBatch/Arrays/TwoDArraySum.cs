using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Arrays
{
    internal class TwoDArraySum
    {

        static void Main(string[] args)
        {
            int[,] a = { { 3, 8 }, { 9, 4 } };
            int [,] b = { { 5, 6 }, { 7, 8 } };

            Console.WriteLine("Array 1: ");
            for(int i=0; i < a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+"  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Array 2: ");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Addition of both arrays is: ");
            int[,] sum = new int[b.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(sum[i, j] = a[i, j] + b[i, j]);
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
        }
    }

    class RowViseAvg
    {
        static void Main(string[] args)
        {
            int[,] a = { { 3, 8, 4 }, { 9, 4 , 7}, { 19, 5, 23} };
            int avg, sum;
            Console.WriteLine("Array 1: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Row vise average: ");
            for(int i=0; i < a.GetLength(0); i++)
            {
                sum = 0;
                avg = 0;
                for(int j=0; j<a.GetLength(1); j++)
                {
                    sum = sum + a[i, j];
                    avg = sum / a.GetLength(0);
                    Console.Write(a[i,j]+"   ");
                }
                Console.Write("   ="+avg);
                Console.WriteLine();          
            }
        }
    }

    class ColumnViseSum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 3, 8, 4 }, { 9, 4, 7 }, { 1, 5, 3 } };
            int avg, sum;
            Console.WriteLine("Array elements are: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "    ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------");
            //Console.WriteLine("Column vise sum: ");
            for (int i = 0; i < a.GetLength(1); i++)
            {
                sum = 0;
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    
                    sum = sum + a[j,i];
                }
                Console.Write(sum+"   ");

            }
        }
    }
}
