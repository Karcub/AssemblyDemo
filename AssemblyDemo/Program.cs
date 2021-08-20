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
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Type attrType = typeof(AssemblyDescriptionAttribute);
            object[] attrs = currentAssembly.GetCustomAttributes(attrType, false);

            if (attrs.Length > 0)
            {
                AssemblyDescriptionAttribute desc = (AssemblyDescriptionAttribute)attrs[0];
                Console.WriteLine("Description is: {0}", desc.Description);
            }
        }
    }
}