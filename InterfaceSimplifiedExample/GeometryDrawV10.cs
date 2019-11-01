using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSimplifiedExample
{
    class GeometryDrawV10 : IGeometryDraw
    {
        public void DrawCircle(double x, double y, double radius)
        {
            //throw new NotImplementedException();
            Console.WriteLine("I am DrawCircle");
        }

        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            //throw new NotImplementedException();
            Console.WriteLine("I am drawline");
        }

        public void DrawRectangle(double x1, double y1, double x2, double y2)
        {
            //throw new NotImplementedException();
            Console.WriteLine("I am DrawRectangle");
        }
    }
}
