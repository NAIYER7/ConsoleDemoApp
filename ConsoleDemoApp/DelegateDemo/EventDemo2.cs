﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.DelegateDemo
{
    public delegate void MyEventHandler2(int num);

    class Publisher {

        public event MyEventHandler2 Cube;

        public void Notify(int num) {

            if(Cube!=null)
                 Cube.Invoke(num);//event invocation
            else
               Console.WriteLine("No subscription for event Cube");
        }    
    }
    //Subscriber class
    internal class EventDemo2
    {
        //handler method/logic
        static void GetCube(int number) {
            Console.WriteLine($"Cube of {number} is {number*number*number}");
        }
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            publisher.Cube += EventDemo2.GetCube;//subscrption
            publisher.Notify(5);
            Console.WriteLine("========");
            publisher.Cube += (num) => { Console.WriteLine(num*num); };
            publisher.Notify(10);
           //MyConsole.Console ob = new MyConsole.Console();

        }
    }
    //namespace MyConsole { 
    //class Console { 
    //}
    //}


}
