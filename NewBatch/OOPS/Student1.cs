using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.OOPS
{
    internal class Student1
    {
        int Roll_No;
        String Name;
        float per;

        void accept_Details()
        {
            Console.WriteLine("Enter Student Name: ");
             Name = Console.ReadLine();
            Console.WriteLine("Enter Roll number: ");
            Roll_No = int.Parse(Console.ReadLine());
        }
        float percentage()
        {
            Console.WriteLine("Enter Marks of Subjets: ");
            int sub1 = int.Parse(Console.ReadLine());
            int sub2 = int.Parse(Console.ReadLine());
            int sub3 = int.Parse(Console.ReadLine());
            int total = sub1 + sub2 + sub3;
            per = (total * 100) / 300;
            return per;
        }

        void display()
        {
            Console.WriteLine("\n\n\nDetails of Student: ");
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("Roll Number: "+Roll_No);
            Console.WriteLine("Percentage : "+per);
        }

        static void Main(string[] args)
        {
            Student1 s1 = new Student1();
            s1.accept_Details();
            s1.percentage();
            s1.display();
        }
    }

    class reverseNo
    {
        static void Main(string[] args)
        {
            int n = 121;
            int i = 1, rem = 0, reverse = 0;

            while (i != 0)
            {
                rem = n % 10;
                reverse = reverse*10 + rem;
                n = n / 10;
            }
            Console.WriteLine(reverse);
        }
    }

    //1,3,7,15

    class Series
    {
        static void Main(string[] args)
        {
            int sum = 0, i;
            Console.WriteLine("Enter the range: ");
            int n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                sum = (sum * 2) + 1;
                Console.WriteLine(sum + " ");
            }
        }
    }



    class Bank
    {
        int Acc_no;
        String Acc_type, Cust_name;
        double balance;
        

        void acc_details()
        {
            Console.WriteLine("Enter the Details of Account Holder: ");
            Console.WriteLine("Enter Account Number: ");
            Acc_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Type: ");
            Acc_type = Console.ReadLine();
            Console.WriteLine("Enter Customer Name: ");
            String Cust_name = Console.ReadLine();
            Console.WriteLine("Enter Balance: ");
            balance = double.Parse(Console.ReadLine());
        }

        void show_details()
        {
            Console.WriteLine("Details of Accounter Holder: ");
            Console.WriteLine("Account Number: "+Acc_no);
            Console.WriteLine("Account Type: "+Acc_type);
            Console.WriteLine("Customer Name: "+Cust_name);
            Console.WriteLine("Account Balance: "+balance);
        }

        void deposite()
        {
            Console.WriteLine("Enter Amount to be deposite: ");
            double depo = double.Parse(Console.ReadLine());
            balance = balance + depo;
            show_details();
        }
        void withdrawl()
        {
            Console.WriteLine("Enter Amount to be Withdraw: ");
            double with = double.Parse(Console.ReadLine());
            balance = balance -  with;
            show_details();
        }


        static void Main(string[] args)
        {
            

            Bank bank = new Bank();
            bank.acc_details();
            bank.show_details();


            Console.WriteLine("Select: ");
            Console.WriteLine("1: Deposite \n2:Withdraw");
            int ch= int.Parse(Console.ReadLine());
            if(ch == 1)
            {
                
                bank.deposite();
            }
            else if (ch == 2)
            {
                
                bank.withdrawl();
            }
            else
            {
                Console.WriteLine("Wrong choice..");
            }

            


        }
    }
}
