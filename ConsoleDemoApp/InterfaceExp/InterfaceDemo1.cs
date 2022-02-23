using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.InterfaceExp
{
    interface ICalc1 {
        //int id;
        int Add(int x, int y);//public and abstract
        int Subtract(int x, int y);
        //public void show() { 
        //}    
    }
    //Interface inheritance
    interface ICalc2:ICalc1
    {
        new int Subtract(int x, int y);//public and abstract
       // int Add(int x, int y);

    }

    //Multiple inheritance like implementaion
    class Calculator :  ICalc2
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
    internal class InterfaceDemo1
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Sum:"+calc.Add(30,20));
            Console.WriteLine("Difference:"+calc.Subtract(50,20));
            //Creating Interface
            ICalc1 icalc1 = calc;
            Console.WriteLine("Sum:"+icalc1.Add(40,30));
            Console.WriteLine("Difference:" + icalc1.Subtract(40, 30));

            ICalc2 icalc2 = calc;
            Console.WriteLine("Sum: " + icalc2.Add(100, 30));
            Console.WriteLine("Difference: "+icalc2.Subtract(100,30));




        }
    }
}
