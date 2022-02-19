using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6
{

    //Employee.dll
    public class Employee
    {
        int _age;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Expression body read-only property ,C#6.0
        public string FullName => $"{FirstName} {LastName}";

        //Expression body read-write property, C#7.0
        public int Age { 
            get => _age;
            set => _age = value;        
        }
        // static void Main(string[] args)=>Console.WriteLine("Hello World");
        static void Main(string[] args)
        {
            Employee emp = new Employee() {FirstName="Rahul",LastName="Kumar",Age=24 };
            Console.WriteLine(emp.FullName);
            Console.WriteLine(emp.Age);
        }
    }
}
