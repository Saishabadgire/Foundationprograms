using System;
using System.Xml.Linq;

namespace constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            student lobjs1 = new student();
            lobjs1.printinfo();



            Console.Write("enter value for name:");
            string lstrname = Console.ReadLine();
            Console.Write("enter value for id:");
            int lintID =Convert.ToInt32 (Console.ReadLine());

            student lobjs2 = new student(lintID,lstrname,"23456****");
            lobjs2.printinfo();



           student person1 = new student( 25 , "Alice");
            person1.Introduce();


        }
    }
}
