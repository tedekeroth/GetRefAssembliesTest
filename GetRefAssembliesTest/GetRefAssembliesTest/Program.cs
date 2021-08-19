using System;
using System.Linq;
using System.Reflection;

namespace GetRefAssembliesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Assembly.GetEntryAssembly().GetReferencedAssemblies();
            System.Diagnostics.Debug.WriteLine($"{string.Join(", ", list.Select(a => a.Name)) }");
        }
    }
}
