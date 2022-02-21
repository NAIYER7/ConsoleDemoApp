using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day8
{
    internal class StringBuilderDemo
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(30);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.MaxCapacity);
            Console.WriteLine(sb);
            sb.AppendFormat("C sharp is {0} {1}", "object oriented programming langugae",20);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.MaxCapacity);
            Console.WriteLine(sb);
            sb.AppendLine();
            sb.AppendLine("It's case sensitive");
            Console.WriteLine(sb);
            //Console.WriteLine(sb);
            sb.Insert(47, "C Sharp is event driven.");
            Console.WriteLine(sb);





        }
    }
}
