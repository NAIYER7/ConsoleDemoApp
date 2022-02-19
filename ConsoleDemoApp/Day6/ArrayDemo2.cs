using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6
{
    internal class ArrayDemo2
    {
        public static void Display(int[][]arr) {

            Console.WriteLine("matrix values are:");
            for (int r = 0; r < arr.Length; r++)
            {
                for (int c = 0; c < arr[r].Length; c++)
                {
                    Console.Write($"{arr[r][c]}\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //int[][] jagged = new int[4][];//4 1-D array 

            //jagged[0] = new int[5] { 1,2,3,4,5};
            //jagged[1] = new int[3] { 6,7,8};
            //jagged[2] = new int[2] { 9,10};
            //jagged[3] = new int[4] { 11,12,13,14};

            int[][] jagged = new int[4][]
                            {
                                new int[5]{ 1,2,3,4,5},//5,1
                                new int[3] { 6,7,8},   //3,1
                                new int[2] { 9, 10 },  //2,1
                                new int[4] { 11, 12, 13, 14 }//4,1
                            };          

            Console.WriteLine("Rank :"+jagged.Rank);//1
            Console.WriteLine("Length :" + jagged.Length);//4
            Console.WriteLine(jagged[0].Length);
            Console.WriteLine(jagged[0].Rank);
            Display(jagged);


        }
    }
}
