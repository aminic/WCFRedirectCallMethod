using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(2 * 1000);

            var baseUrl = "http://localhost:999/";
            var c = new WSClient(baseUrl);
            var s = c.GetService<IMyService>();
            Console.Write("CALL Hello Method result:");
            var r1 = s.Hello("anders");
            Console.WriteLine(r1);

            Console.Write("CALL Welcome Method result:");
            var r2 = s.Welcome("anders");
            Console.WriteLine(r2);

            Console.Read();
        }
    }
}
