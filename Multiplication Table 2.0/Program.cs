﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("{0} X {1} = {2}", number, times, number * times);
                times++;
            } while (times <= 10);
        }
    }
}
