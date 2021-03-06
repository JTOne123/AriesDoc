﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Pandv.AriesDoc.Generator;
using System.IO;

namespace Example
{
    /// <summary>
    /// sdadas
    /// dadasda
    /// </summary>
    public class Student
    {
        /// <summary>
        /// asDd
        /// sADA
        /// </summary>
        public string Name { get; set; }
    }

    public class Program
    {
        public string Name { get; set; }

        public Student Student { get; set; }

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}