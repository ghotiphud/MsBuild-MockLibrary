using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RealLibrary;

namespace MockLibraryRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var cls = new Class1();

            Console.WriteLine(cls.ToString());
            Console.ReadKey();
        }
    }
}
