using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Abstraction
{

    public interface IVar1
    {
        static int x=100;
        //void print();
    }
     abstract class Var2
    {
        public int y=200;
       //public abstract void print();
    }

    class Addition:Var2, IVar1
    {
       public void add()
        {
            Console.WriteLine("Addition of IVar1 and Var2 is: " + (IVar1.x + y));
        }
    }

    class ShowAddition
    {
        static void Main(string[] args)
        {
            Addition ad = new Addition();
            ad.add();   
        }
    }

    class ArraySorting
    {
        static void Main(string[] args)
        {
            int[] a = {6,8,2,3,9,4,1,10,5,7 };
            Console.WriteLine("Array Elements are: "+String.Join(" ",a));

            Console.WriteLine("Array after asssending and descending:");
            for(int i=0; i<a.Length; i++)
            {
                
                for(int j=i+1; j < a.Length / 2; j++)
                {
                    if(a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for(int i=a.Length/2; i<a.Length; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", a));
        }
    }
}
