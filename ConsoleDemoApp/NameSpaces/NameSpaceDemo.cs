using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyConsole = System.Console;
using MConsole = ConsoleDemoApp.NameSpaces.Console;
namespace ConsoleDemoApp.NameSpaces{
    internal class NameSpaceDemo    {
        static void Main(string[] args)        {
            //Console.WriteLine("fshdsgfhds");//using statement

           System.Console.WriteLine("fshdsgfhds");//full qualified name

            MyConsole.WriteLine("sdhsfdsh");//using alias
            Console obj = new Console();
            obj.Print();
            MConsole obj2 = new MConsole();
        }
    }
    class Console {
        public void Print() {
            System.Console.WriteLine("fsgdfsgds");
            MyConsole.WriteLine("sdhsfdsh");

        }
    }
}
