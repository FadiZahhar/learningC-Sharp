﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new HandyDandyApplication();
            app.DisplayUsers(Console.Out);
            Console.Read();
        }
    }
}
