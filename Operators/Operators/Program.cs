﻿using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)
        }
    }
}