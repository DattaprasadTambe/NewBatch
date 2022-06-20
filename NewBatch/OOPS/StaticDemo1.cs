using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.OOPS
{

    class StaticOverload
    {
        static int a;
        int b;

        public void Addition(int x, int y)
        {
            a = x;
            b = y;
            Console.WriteLine("Addition : "+(a+b));
        }
        public static void Division(int x, int y)
        {
            StaticOverload s = new StaticOverload();
            a = x;
             s.b = y;
            int c = a / s.b;
            Console.WriteLine("Division :"+c);
        }
    }
    internal class StaticDemo1
    {
        static void Main(string[] args)
        {
            StaticOverload SO = new StaticOverload();
            SO.Addition(10, 5);
            StaticOverload.Division(10,5);
        }
    }

    static class StaticClassDemo
    {
        /*public StaticClassDemo()
        {

        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hii..");
        }
    }

    static class StaticClassDemo2
    {
        /*
        private StaticClassDemo2()
        {

        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("hii");
        }
    }

    class StaticOverloading
    {
        static int x = 10;

        static void show()
        {
            Console.WriteLine(x);
        }
        static void show(int a)
        {
            Console.WriteLine(x);
            Console.WriteLine(a);
        }
        static void show(int a, int b)
        {
            Console.WriteLine(x);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {

        }
    }

    class Overload
    {
        int x = 10;
        public static void get()
        {
            Overload o = new Overload();
            Console.WriteLine("First Method");
            Console.WriteLine(o.x);
        }
        public static void get(int a)
        {
            Overload o = new Overload();
            Console.WriteLine("Second Method");
            Console.WriteLine(o.x+" "+a);
        }
        public static void get(int a, int b)
        {
            Overload o = new Overload();
            Console.WriteLine("Third Method");
            Console.WriteLine(o.x+" "+a+" "+b);
        }
    }
    class MethodOver
    {
        static void Main(string[] args)
        {
            Overload.get();
            Overload.get(10);
        }
    }
}
