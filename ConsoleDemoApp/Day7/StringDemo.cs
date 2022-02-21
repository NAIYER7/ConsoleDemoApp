using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day7
{
    internal class StringDemo
    {
        static void Main(string[] args)
        {
            //string s1 = "cdac";
            //string s2 = "cdac";
            //StringBuilder sb1 = new StringBuilder("cdac");
            //StringBuilder sb2 = new StringBuilder("cdac");
            ////String s=new String()
            //Console.WriteLine(s1==s2);
            //Console.WriteLine(sb1==sb2);
            //Console.WriteLine(sb1.Equals(sb2));
            //Console.WriteLine(s1.Equals(s2));
            //Console.WriteLine(s1.GetHashCode());
            //Console.WriteLine(s2.GetHashCode());
            //Console.WriteLine(sb1.GetHashCode());
            //Console.WriteLine(sb2.GetHashCode());

            //string str2 = "";
            //str2 = string.Empty;
            //if (str2 == string.Empty) {

            //}
            //if (str2.Equals(string.Empty))
            //{

            //}

            //int x = 20;
            //int y = 30;
            //string str = string.Format("value of x:{0}\tvalue of y:{1}", x, y);

            //Console.WriteLine(str);

            StringBuilder sb = new StringBuilder("C Sharp",20);
            Console.WriteLine(sb.Length);//0
            Console.WriteLine(sb.Capacity);//some deafult capacity value
            Console.WriteLine(sb.MaxCapacity);//default max capacity value
            //Console.WriteLine(Int32.MaxValue);
            Console.WriteLine(sb);
            sb.Append("is programming language");
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb);
           




        }
    }
}
