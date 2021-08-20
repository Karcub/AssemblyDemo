using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace AssemblyDemo
{
    class Program
    {
        public static void Main()
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll";

            // Load a specific Assembly
            Assembly assembly = Assembly.LoadFile(path);
            ShowAssemblyInfo(assembly);

            // Get our Assembly
            Assembly ourAssembly = Assembly.GetExecutingAssembly();
            ShowAssemblyInfo(ourAssembly);

            Console.Read();
        }

        static void ShowAssemblyInfo(Assembly assembly)
        {
            Console.WriteLine(assembly.FullName);
            Console.WriteLine("From GAC? {0}", assembly.GlobalAssemblyCache);
            Console.WriteLine("Path: {0}", assembly.Location);
            Console.WriteLine("Version: {0}", assembly.ImageRuntimeVersion);

            // Show Modules
            foreach (Module method in assembly.GetModules())
            {
                Console.WriteLine(" Mod: {0}", method.Name);
            }

            Console.WriteLine();
        }
    }
}