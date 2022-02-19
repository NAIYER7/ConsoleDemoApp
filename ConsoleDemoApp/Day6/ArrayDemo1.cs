using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6
{
    internal class ArrayDemo1
    {
        static void Main(string[] args)
        {
            //Normal Array
            // int[] arr;//decln
            // arr = new int[5];//intialization
            //int[, ,] arr = new int[5,4,5];//decln + intialization with default values
            //Console.WriteLine(arr.Length);//no of elements stored in array
            //Console.WriteLine(arr.Rank);//dimension of array

            //Console.WriteLine(arr.GetUpperBound(0));//4
            //Console.WriteLine(arr.GetUpperBound(1));//3
            //Console.WriteLine(arr.GetUpperBound(2));//4
            //Console.WriteLine(arr.GetLength(0));//5
            //Console.WriteLine(arr.GetLength(1));//4
            //Console.WriteLine(arr.GetLength(2));//5
            // int[] arr = new int[6] { 1, 2, 3, 4, 5, 6 };

            int[] arr ={ 10, 2, 3, 40, 5, 60 };

            Console.WriteLine("Arrays elements are:");
            //for (int i = 0; i <arr.Length ; i++)
            //for (int i = 0; i < arr.GetLength(0); i++)
            for (int i = 0; i <=arr.GetUpperBound(0); i++)
            {
                Console.WriteLine(arr[i]);
            }

            //Console.WriteLine("Input array values:");
            //for (int i = 0; i <= arr.GetUpperBound(0); i++)
            //{
            //    Console.WriteLine($"Enter element {i+1} value:");
            //    arr[i]=Int32.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Current Arrays elements are:");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Average());

            Array.Sort(arr);
           // Array.Reverse(arr);
            Console.WriteLine("Sorted Arrays elements are:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }            
            int x = 60;
            bool res = arr.Contains(x);
            Console.WriteLine("result:"+res);

            //int[] arr2 = { 10, 20, 30, 40, 50, 60 };
            int[] arr2 = arr;//copy
            int result= Array.BinarySearch<int>(arr2, x);
             Console.WriteLine("result:" + result);



        }
    }
}




