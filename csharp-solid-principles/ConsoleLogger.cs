﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solid_principles
{
    public class ConsoleLogger
    {
        public void Log(string message)
        {
             Console.WriteLine($"{message}");
        }
    }
}
