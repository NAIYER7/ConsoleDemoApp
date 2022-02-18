using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    internal class ControlStmt
    {
        static void Main(string[] args)
        {
            //char ch;
            //Console.WriteLine("Enter any char:");
            //ch =Char.Parse( Console.ReadLine());
            //switch (ch)
            //{
            //    default:
            //        Console.WriteLine("Invalid");
            //        break;
            //    case 'a':
            //       // Console.WriteLine("eneter char is vowel");
            //       // break;
            //    case 'e':
            //       // Console.WriteLine("eneter char is vowel");
            //       // break;
            //    case 'i':
            //        Console.WriteLine($"entered char {ch} is vowel");
            //        break;               

            //}

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Array values are");
            /*
            foreach (type identifier in collection - name) { 
            //code to be executed
            }
            1-forward only loop
            2-readonly
            */
            //foreach (int item in arr)
            //{
            //    //item = item + 2;//invalid
            //    Console.WriteLine(item);
            //}

            //Boxing
            // object obj = 20;//implicit
            // int y = (int)obj;//unboxing,explicit

            foreach (object item in arr)
            {
                //item = item + 2;//invalid
                Console.WriteLine(item.GetType());
                if ((int)item > 5)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("============================");
            foreach (var item in arr)
            {
                Console.WriteLine(item.GetType());
                if (item > 5)
                    Console.WriteLine(item);
            }
            /// dynamic obj;
            foreach (dynamic item in arr)
            {
                Console.WriteLine(item.GetType());
                if (item > 5)
                    Console.WriteLine(item);
            }












        }
    }
}
