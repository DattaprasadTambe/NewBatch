using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.OOPS
{
    
    internal class Cars
    {
        int Model_No, C_price;
        string C_name;
        String C_color;

        void input1()
        {
            Model_No = 101;
            C_name = "Slavia";
            C_color = "Matt Black";
            C_price = 1550000;
        }
        void display1(String car1)
        {
            Console.WriteLine("Model Number :"+Model_No);
            Console.WriteLine("Car Name : "+C_name);
            Console.WriteLine("Car Color : "+C_color);
            Console.WriteLine("Car Price : "+C_price);
        }
        void input2()
        {
            Model_No = 102;
            C_name = "Creta";
            C_color = "Red";
            C_price = 1750000;
        }
        void display2(String car2)
        {
            Console.WriteLine("Model Number :" + Model_No);
            Console.WriteLine("Car Name : " + C_name);
            Console.WriteLine("Car Color : " + C_color);
            Console.WriteLine("Car Price : " + C_price);
        }

        static void Main(string[] args)
        {
            Cars c = new Cars();
            Console.WriteLine("Enter the Car name: ");
            String car1 = Console.ReadLine();
            c.input1();
            c.display1(car1);
            Console.WriteLine("Enter the second Car name: ");
            String car2 = Console.ReadLine();
            c.input2();
            c.display2(car2);

        }
    }
}
