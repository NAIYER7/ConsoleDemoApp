using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleDemoApp.Day8
{
    internal class StringDemo
    {
        static void Main(string[] args)
        {
            string str = "abcd123efgh43ijkl87mnop88qrst77uvwz33yz";
            //123,43,56,88,77,33
            //Regular Expression
            //Regex
            //Match
            //MatchCollection
            bool result=Regex.IsMatch(str, "\\d");
            Console.WriteLine(result);
            result = Regex.IsMatch(str, @"\d{4}");
            Console.WriteLine(result);
            Console.WriteLine(str);
            Console.WriteLine("===================");
            //Match match = Regex.Match(str, "\\d{2,}");
            //Console.WriteLine(match.Success);
            //Console.WriteLine(match.Value);
            //Console.WriteLine(match.Length);
            //match = match.NextMatch();
            //Console.WriteLine(match.Value);
            //match = match.NextMatch();
            //Console.WriteLine(match.Value);

            MatchCollection matches=   Regex.Matches(str, @"\d{2,}");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
            Console.WriteLine("=================================");
            string[]splitdata=   Regex.Split(str, @"\d{2,}");
            Console.WriteLine("split Data:");
            foreach (var data in splitdata)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("==================================");
            string newstr=  Regex.Replace(str, @"\d{2,}", "_");
            Console.WriteLine(newstr);
            //Math class
            Random rm = new Random();
            int num = rm.Next(10000,99999);
            Console.WriteLine("random:"+num);

        }
    }
}
