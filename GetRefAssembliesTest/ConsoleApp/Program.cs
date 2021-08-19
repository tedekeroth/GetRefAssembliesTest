using System;
using System.Linq;
using System.Reflection;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Assembly.GetEntryAssembly().GetReferencedAssemblies();
            Console.WriteLine($"Printing results from GetReferencedAssemblies():{Environment.NewLine}{string.Join(", ", list.Select(a => a.Name)) }");
        }
    }
}
