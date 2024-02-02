﻿using System;
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
            MyRandom.lang = "en";
            MyRandom.langChange(MyRandom.lang);

            FoodTest ft = new FoodTest();
            ft.Test();
            DateTest dt = new DateTest();
            dt.Test();
            TextTest tt = new TextTest();
            tt.Test();
            NumberTest nt = new NumberTest();
            nt.Test();
            NameTest nmt = new NameTest();
            nmt.Test();
            CitiesTest ct = new CitiesTest();
            ct.Test();


            Console.ReadLine();
        }
    }
}
