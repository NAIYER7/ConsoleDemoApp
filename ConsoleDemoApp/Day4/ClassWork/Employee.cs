using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    internal class Employee
    {
        int _IdNo;    //non-static
        string _Name;//non-static
        static int id;//static data field,object independent
        
        public Employee()
        {
            Console.WriteLine("Default constructor");
            //this._IdNo = 1000;
            this._IdNo = id++;
            this._Name = "admin";
        }
        public Employee(int _IdNo)//10000
        {
            Console.WriteLine("Parametrized constructor for IdNo");
            this._IdNo = _IdNo;
            id = _IdNo+1;//updating static id with user value
        }
        public Employee(string _Name)
        {
            Console.WriteLine("Parametrized constructor for Name");
            this._Name =_Name;
            this._IdNo = id++;//1001,1002
        }
        public Employee(int _IdNo,string _Name)//5000
        {
            Console.WriteLine("Parametrized constructor for Name and ID");
            this._Name = _Name;
            this._IdNo = _IdNo;
            id = _IdNo+1;//updating static id with user value
        }

        //static constructor
        static Employee() {
            Console.WriteLine("static constr called");
            Console.WriteLine("it's used to initialize the class static data fields ");
            id = 1000;//intitial default
        }
        public Employee SetEmpData(int IdNo,string Name) {
            this._IdNo = IdNo;
            this._Name = Name;
            Console.WriteLine("Employee details saved");
            return this;
            
        }
        public void DisplayEmpData()
        {
            Console.WriteLine($"Id:{_IdNo}\tName:{_Name}");
        }
        public override string ToString()
        {
            return $"Id:{_IdNo}\tName:{_Name}";
        }
    }

    class EmployeeMain
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee();
            Console.WriteLine(emp1);
            Employee emp2 = new Employee();
            Console.WriteLine(emp2);
            
            Employee emp3 = new Employee(10000);
            Console.WriteLine(emp3);

            Employee emp4 = new Employee();
            Console.WriteLine(emp4);
            /*
            Employee emp3 = new Employee("Rahul");
            Console.WriteLine(emp3);
            Employee emp4 = new Employee(1000,"Abhishek");
            Console.WriteLine(emp4);*/
        }
    }

}
