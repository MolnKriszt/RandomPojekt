using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3;

namespace Teszt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTest dt = new DateTest();
            dt.Test();
            TextTest tt = new TextTest();
            tt.Test();
            NumberTest nt = new NumberTest();
            nt.Test();
            Console.WriteLine("helo szia");
            Console.WriteLine("dsa");
            Console.WriteLine("asd");
            Console.WriteLine("ert");
            Console.WriteLine("Gyuri");
            Console.WriteLine( "Gergő" );

            Console.ReadLine();
        }
    }
}
