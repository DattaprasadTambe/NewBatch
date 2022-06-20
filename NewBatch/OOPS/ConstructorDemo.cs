using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.OOPS
{
    internal class ConstructorDemo
    {

        int id;
        String name;
        long Mob_No;

        ConstructorDemo(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        //default constructor

        ConstructorDemo(int id, String name, long Mob_no)
        {
            this.id = id;
            this.name = name;
            this.Mob_No = Mob_no;
        }


        void display()
        {
            Console.WriteLine(id + "\n" + name + "\n" + Mob_No);
        }

        static void Main(string[] args)
        {
            ConstructorDemo C_demo = new ConstructorDemo(01, "Raftaar");
            ConstructorDemo C_demo2 = new ConstructorDemo(21, "DP", 9087654321);
            C_demo2.display();
        }
    }
    class MethodOverloading
    {
            int calculate(int a, int b)
            {
                return a + b;
            }
            float calculate(int x, float y)
            {
                return x * y;
            }
            int calculate(int a, int b, int c)
            {
                return a - b - c;
            }
            float calculate(float a, float b)
            {
            float c = a / b;
                return c;
            }

            static void Main(string[] args)
            {
                MethodOverloading MO = new MethodOverloading();
                Console.WriteLine("Addition = "+MO.calculate(10, 5));
                Console.WriteLine("Subtraction = "+MO.calculate(20,10,5));
                Console.WriteLine("Multiplication = "+MO.calculate(5, 10f));
                Console.WriteLine("Division = "+MO.calculate(50f, 10f));
            }
            
     }

    class Overload_Area
    {
        void Area(int r)
        {
            float pi = 3.14f;
            float area = pi * (r * r);
            Console.WriteLine("Area of Circle: "+area); 
        }
        void Area(int l , int b)
        {
            float area = l * b;
            Console.WriteLine("Area of rectangle: "+area);
        }

        void Area(float h, float b)
        {
            float area = (h * b) / 2;
            Console.WriteLine("Area of triangle: "+area);
        }
        void Area(float s)
        {
            float area = s*s;
            Console.WriteLine("Area of Square: "+area);
        }

        static void Main(string[] args)
        {
            Overload_Area OA = new Overload_Area();
            OA.Area(5);
            OA.Area(10,10);
            OA.Area(10f, 10.50f);
            OA.Area(5f);

        }
    }

    class Student2
    {
        int id;
        String name;
        int marks;
        void acc_details()
        {
            Console.WriteLine("Enter ID: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Marks: ");
            marks = int.Parse(Console.ReadLine());
        }
        void show_details()
        {
            Console.WriteLine("ID : "+id);
            Console.WriteLine("Name : "+name);
            Console.WriteLine("Marks : "+marks);
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            Student2 s1 = new Student2();
            s1.acc_details() ;
            Console.WriteLine("\n");
            Student2 s2 = new Student2();
            s2.acc_details();
            Console.WriteLine("\n");
            Student2 s3= new Student2();
            s3.acc_details();
            Console.WriteLine("\n");

            s1.show_details();
            s2.show_details();
            s3.show_details();
        }
    }
    
    class ConstOverDemo
    {

        public ConstOverDemo()
        {
            Console.WriteLine("Constructor without parameter..");
        }
        public ConstOverDemo(int ModelNo)
        {
            Console.WriteLine("First Overloaded Constructor with single parameter..");
            Console.WriteLine("Car Model Number is: "+ModelNo);
        }
        public ConstOverDemo(int ModelNo, string brand)
        {
            Console.WriteLine("Second Overloaded Constructor with two parameters..");
            Console.WriteLine("Car Model No: "+ModelNo+"\nCar Brand: "+brand);
        }

        static void Main(string[] args)
        {
            ConstOverDemo CO = new ConstOverDemo(); 
            ConstOverDemo CO1 = new ConstOverDemo(101);
            ConstOverDemo CO2 = new ConstOverDemo(102, "Skoda");
        }
    }

    class StaticDemo
    {
        static int x;

        void get(int x)
        {
            StaticDemo.x = x;
        }
        void display()
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            StaticDemo s = new StaticDemo();
            s.get(300);
            s.display();
        }
    }
}
