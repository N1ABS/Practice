using System;
using System.Xml.Linq;

namespace Practice3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person anuar = new Person();
            anuar.Name = "Anuar";

            anuar.Print();

            Employee nurbolat = new Employee();
            nurbolat.Name = "Nurbolat";
            nurbolat.Company = "ATI";
            nurbolat.Print();

            Person nurbolat2 = nurbolat;
            nurbolat2.Print();
        }
    }


    public class Person
    {
        public string Name { get; set; }

        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }

    public class Employee : Person
    {
        public string Company { get; set; }

        public override void Print()
        {
            Console.WriteLine(Name + " works at " + Company);
        }
    }
}