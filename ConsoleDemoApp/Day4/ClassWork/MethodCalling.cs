using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    internal class MethodCalling
    {
        static void Call_By_Value(int x, int y) {
            x = x + 30;
            y = y + 40;
            Console.WriteLine($"x:{x}\ty:{y}");//50,80
        }

        static void Call_By_Refrence(ref int x, ref int y)
        {
            x = x + 30;
            y = y + 40;
            Console.WriteLine($"x:{x}\ty:{y}");//50,80
        }

        static void Call_By_OutputParameter(int x, int y,out int sum,out int diff)
        {
            sum = x + y;
            diff=x - y;
            
        }
                                                             //default argumnent/optional argument
        static void Call_By_Named_Default(string  fname,
                                           string lname="Kumar",float salary=25000)
        {
            Console.WriteLine($"Welcome:{fname} {lname}");
            Console.WriteLine($"Your Salary is:{salary}");
        }

        //params argument
        static int SumValues(int id,params int[]arr) {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        } 

        static void Main(string[] args)
        {
            /*
            int a=20, b=40;
            Console.WriteLine($"a:{a}\tb:{b}");//20,40
            // MethodCalling.Call_By_Value(a,b);//static method call
           // Console.WriteLine("===========================");
            Call_By_Refrence(ref a,ref  b); //&a,&b
            Console.WriteLine($"a:{a}\tb:{b}");//50,80
            
            // int a = 30, b = 20, s, differnce;
            // Call_By_OutputParameter(a, b, out s,out differnce);
            //  Console.WriteLine($"Sum:{s}\tDifference:{differnce}");
            Call_By_Named_Default("Rahul","Kumar",24500);//valid
            //named argument
            Call_By_Named_Default(lname:"Kumar",fname:"Rahul",salary:24500);//valid
            Call_By_Named_Default(salary:36000,fname:"Rahul", lname:"Kumar");//valid
            Call_By_Named_Default("Rahul", "Kumar");//salary=25000
            Call_By_Named_Default("Manish", salary:34500);
            */

            int res = SumValues(10,new[] { 1, 2, 3, 4, 5 });//15
            Console.WriteLine("result :"+res);

            res = SumValues( 1, 2, 3, 4, 5 ,6);
            Console.WriteLine("result :" + res);//20

            res = SumValues(1, 2, 3, 4);//9
            Console.WriteLine("result :" + res);
            res = SumValues(1, 2);//2
            Console.WriteLine("result :" + res);

            //createArray(type,params int[]arr)
            //create(integer,10)
            //create(float,3,4)
            //craete(long,3,4,5)





        }
    }
}
