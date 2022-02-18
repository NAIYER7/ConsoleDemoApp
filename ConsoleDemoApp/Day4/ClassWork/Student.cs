using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    /*
       1-methods
       2-constructor-fails
       3-By making data fields public,incorrect way
    */
    internal class Student
    {
        int _RollNo;
        string _Name;
        int _Age;
        public void SetRoll(int roll) {
            this._RollNo = roll;//write operation
        }
        public int GetRoll()
        {
            return this._RollNo;//read operation
        }

    }

    class StudentMain {
        static void Main(string[] args)
        {
            Student obj = new Student();
           // obj._RollNo = 2000;
           // Console.WriteLine(obj._RollNo);
        }
    }
}
