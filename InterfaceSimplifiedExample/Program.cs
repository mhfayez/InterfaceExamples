using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSimplifiedExample
{
    class Program
    {
        static void Main(string[] args)
        {

            GeometryDrawV10 geometry = new GeometryDrawV10();

            geometry.DrawCircle(1.0, 1.2, 2.0);

            Console.ReadKey();
        }
    }
}
