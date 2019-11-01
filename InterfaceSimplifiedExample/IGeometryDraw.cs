using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSimplifiedExample
{
    public interface IGeometryDraw
    {
        void DrawCircle(double x, double y, double radius);
        void DrawLine(double x1, double y1, double x2, double y2);
        void DrawRectangle(double x1, double y1, double x2, double y2);

    }
}
