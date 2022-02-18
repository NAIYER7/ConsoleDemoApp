using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    internal static class StaticDemo
    {
        public static int id;
        static StaticDemo()
        {
            Console.WriteLine("Static constr");
            id = 1000;
        }
        public static void Display() {
            Console.WriteLine($"{id}");
        }
    }
    class StaticMain
    {       
        static void Main(string[] args)
        {
            //StaticDemo obj;//= new StaticDemo();
            //obj.Dispaly()
            StaticDemo.Display();
            Console.WriteLine(StaticDemo.id);
        }
    }
}
