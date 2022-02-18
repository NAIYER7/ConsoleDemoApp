using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day3
{

    enum Month
    {
        Jan,Feb,Mar,April,May,Jun
    }

    internal class Third
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Password:");
            //ConsoleKeyInfo ck = Console.ReadKey();//displays pressed keychar on console
            //ConsoleKey and ConsoleKeyInfo are defined in System namespace
            ConsoleKeyInfo ck = Console.ReadKey(true);////hides pressed keychar on console
            string password = "";
            while (ck.Key != ConsoleKey.Enter)
            {
                Console.Write("*");
                password = password+ ck.KeyChar;
                ck= Console.ReadKey(true);
            }
            Console.WriteLine("\nEntered Password:"+password);
           
            ///abcdef enter
            ///******
            ///abcdef



        }
    }
}
