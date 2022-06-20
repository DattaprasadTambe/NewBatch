using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Encapsulation
{
    internal class Car
    {
        private int model_no;
        private string name, color;
        private double price;

        public int Model_no
        {
            get { return model_no; }    
            set { model_no = value; }
        }

        public string Name 
        { 
            get => name; 
            set => name = value; 
        }
        public string Color 
        { 
            get => color; 
            set => color = value; 
        }
        public double Price 
        { 
            get => price; 
            set => price = value; 
        }
    }

    class CarMain
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Model_no = 1969;
            c.Name = "Mustang";
            c.Color = "Black";
            c.Price = 34098909;
            Console.WriteLine(c.Model_no+"\n"+c.Name+"\n"+c.Color+"\n"+c.Price);
        }
    }

    class Student
    {
        private int id;
        private string name;
        private double percentage;
        private bool isStudent;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Percentage { get => percentage; set => percentage = value; }
        public bool IsStudent { get => isStudent; set => isStudent = value; }
    }
    class StudentMain
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 01;
            s.Name = "Dattaprasad";
            s.Percentage = 78.95;
            s.IsStudent = true;
            Console.WriteLine("ID :  "+s.Id+"\nName : "+s.Name+"\nPercentage : "+s.Percentage+"\nIs Student : "+s.IsStudent);
        }
    }


    class Mydate
    {
        private int dd;
        private int mm;
        private int yy;

        public int DD
        {
            get => dd; set => dd = value;   
        }
        public int MM { get => mm; set => mm = value; } 
        public int YY
        {
            get;
            set;
        }
    }

    class Order
    {
        private int o_id;
        private string cust_name;
        private int price;
        private string city;

        public int O_id { get => o_id; set => o_id = value; }
        public string Cust_name { get => cust_name; set => cust_name = value; }
        public int Price { get => price; set => price = value; }
        public string City { get => city; set => city = value; }
    }

    class Shipment
    {
        private int id;
        private Order od;
        private Mydate md;

        static void Main(string[] args)
        {
            Shipment sp = new Shipment();
            sp.id = 01;
            sp.od = new Order();
            sp.od.O_id = 101;
            sp.od.Cust_name = "Dattaprasad";
            sp.od.Price = 1500;
            sp.od.City = "Kankavli";
            sp.md = new Mydate();
            sp.md.DD = 06;
            sp.md.MM = 06;
            sp.md.YY = 2022;

            Console.WriteLine("Shipment Id:"+sp.id+"\nOrder Id: "+sp.od.O_id+"\nCustomer Name: "+sp.od.Cust_name+"\nPrice: "+sp.od.Price+"\nCity: "+sp.od.City+"\nDate: "+sp.md.DD+"\nMonth: "+sp.md.DD+"\nYear: "+sp.md.YY);
        }
    }

    class Nib
    {
        private string materialType;
        public Nib(string materialType)
        {
            this.materialType = materialType;   
        }
        public void showNib()
        {
            Console.WriteLine("Material Type: "+materialType);
        }
    }
    class Pen
    {
        private int length;
        private string color;
        private int price;
        private Nib nb;

        public Pen(int length, string color, int price, Nib nb)
        {
            this.length = length;
            this.color = color;
            this.price = price;
            this.nb = nb;
        }
        public void showPen()
        {
            Console.WriteLine("Length: "+length + "\nColor: " +color+ "\nPrice: "+price);
            nb.showNib();
        }
    }

    class Bag
    {
        private string brand_name;
        private string color;
        private Pen p;

        public Bag(string brand_name, string color, Pen p)
        {
            this.brand_name = brand_name;
            this.color=color;
            this.p = p; 
        }
        public void showBag()
        {
            Console.WriteLine("Brand Name: "+brand_name+"\nColor: "+color);
            p.showPen();
        }

        static void Main(string[] args)
        {
            Bag bg = new Bag("Gucci", "Black",new Pen(12, "Blue", 15, new Nib("Stainless Steel")));
            bg.showBag();   

        }
    }
}
