using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.OOPS
{
    internal class Student
    {

        int id;
        String name;
        double per;
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.id = 1;
            s1.name = "Dattaprasad";
            s1.per = 75.76;
            Console.WriteLine(s1.id+" "+s1.name+" "+s1.per);
        } 
    }
}
