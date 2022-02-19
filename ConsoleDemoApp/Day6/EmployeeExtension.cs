using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6
{
    internal static class EmployeeExtension
    {
        //Extension method for Employee class
        public static void Display(this Employee employee, int x)
        {
            Console.WriteLine($"{employee.FullName}\t{employee.Age}");
        }
        public static void DisplayAge(this Employee employee)
        {
            Console.WriteLine($"{employee.Age+10}");
        }
    }
    class ExtensionTest
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.FirstName = "Rashid";
            emp.Age = 23;
            emp.LastName = "Humayun";
            emp.Display(1000);
            emp.DisplayAge();
        }
    }


}
