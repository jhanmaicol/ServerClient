﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientHandleNetworkData.InitializeNetworkPakages();
            ClienteTCP.ConnectToServer();
            Console.ReadLine();
        }
    }
}
