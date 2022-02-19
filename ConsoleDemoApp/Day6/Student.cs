using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6
{
    internal class Student
    {
        int _RollNo;
        string _Name;
        int _Age;
        string _Course;
        static string _College;//private

        static Student()
        {
            _College = "Astric";
        }

        //property for rollno
        public int RollNo
        {
            get {
                     //some logic
                     return _RollNo;//to read data
                }
            set { 
                     //some logic
                    _RollNo = value;//to write data
                }
        }
        public string Name
        {
            get
            {
                //some logic
                return _Name;//to read data
            }
            set
            {
                //some logic
                _Name = value;//to write data
            }
        }
        public int Age
        {
            get
            {
                //some logic
                return _Age;//to read data
            }
            set
            {
                //some logic
                if(value>0)
                    _Age = value;//to write data
                else
                    Console.WriteLine("only positive value allowed");
            }
        }
        //writonly property
        public string Course
        {
            set { _Course = value; }
        }

        //Readonly property
        public string College
        {
            get { return _College; }
        }


        public override string ToString()
        {
            return $"Roll:{_RollNo}\tName:{_Name}\tAge:{_Age}\tCourse:{_Course}\tCollege:{_College}";
        }


        //auto-implemented property
        //without any class data field
        //for  such property both get and set accessor are cumpulsary
        public int MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }
        public float MyProperty3 { get; set; }
        public  int Math { get; set; }
        public int Hindi { get; set; }



    }

    class StudentMain
    {

        static void Main(string[] args)
        {/*
            Student st = new Student();
            st.RollNo = 1000;
            st.Name = "Rahul";
            st.Age = 24;//write operation,set accessor will be called
            //read operation,get accessor will be called
            Console.WriteLine($"{st.RollNo}\t{st.Name}\t{st.Age}");
            Console.WriteLine(st);

            //object initializer block
            Student st2 = new Student() 
                          { 
                                 RollNo=2000,
                                 Name="Abhishek",
                                 Age=24
                          };
            Student st3 = new Student()
            {
                RollNo = 2002,
                Name = "Mukesh",                
            };
            Student st4 = new Student()
            {
                RollNo = 2003,
                
            };
            Console.WriteLine(st2);
            Console.WriteLine(st3);
            Console.WriteLine(st4);


            Student st5 = new Student();
            st5.Course = "PG-DAC";
            //Console.WriteLine(st5.Course);//inavlid
            Console.WriteLine(st5);

            // st5.College = "C-DAC";//invalid
            Console.WriteLine(st5.College);
           // Console.WriteLine(st5._College);*/
            Student st6 = new Student();
            st6.MyProperty1 = 1000;
            st6.MyProperty2 = "C-DAC";
            st6.MyProperty3 = 456.55f;
            Console.WriteLine(st6.MyProperty1);
            Console.WriteLine(st6.MyProperty2);
            Console.WriteLine(st6.MyProperty3);

            /*
            Employee emp = new Employee();
            emp.FirstName = "Rahul";
            emp.Age = 24;
            emp.Display(2000);
            emp.DisplayAge();*/

        }
    }


}
