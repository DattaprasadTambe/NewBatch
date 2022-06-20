using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Inheritance
{

    class ClassRoom
    {
        public string standard = "12th";
        public int capacity = 60;
    }

    class Stud : ClassRoom
    {
        public string stud_name = "Dattaprasad";
        public string class_teaccher = "Joshi";
        void show()
        {
            Console.WriteLine("Standard: "+standard+ "\nCapacity: "+capacity+"\nStudent : "+stud_name+"\nClass Teacher: "+class_teaccher);
        }
        static void Main(string[] args)
        {
              Stud stud = new Stud();   
            stud.show();
        }

    }

    class Hotel 
    {
        public string name = "Mintleaf";
        public string type = "Veg & Nonveg";
    }
    class Menu: Hotel
    {
        public string menu1 = "Breakfast";
        public string menu2 = "Lunch";
        public string coldd_drink = "Soft Drink";
    }

    class Order : Menu
    {
        public string break_fast = "Idali & Dosa";
        public string lunch = "Starters & Main Course";
        public string soft_drinks = "Sprite & Slice";

        void show()
        {
            Console.WriteLine("Hotel Name: "+name+"\nType: "+type+"\nMenu1: "+menu1+"\nMenu2: "+menu2+"\nCold Drinks: "+soft_drinks+"\nBreak Fast: "+break_fast+"\nLunch: "+lunch+"\nSoft Drinks: "+soft_drinks);
        }

        static void Main(string[] args)
        {
            Order o = new Order();
            o.show();
        }
    }




    internal class SingleLevel1
    {
    }
}
