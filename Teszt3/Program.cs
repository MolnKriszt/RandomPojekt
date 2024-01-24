using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3;

namespace Test3
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
            FoodTest ft = new FoodTest();
            ft.Test();
            
            Console.ReadLine();
        }
    }
}
