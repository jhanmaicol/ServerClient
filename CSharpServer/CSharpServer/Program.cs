﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerTCP.SetupServer();
            Console.ReadLine();
        }
    }
}
