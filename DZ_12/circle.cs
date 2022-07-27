using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_12
{
    class circle
    {
        static public double GetLength(double R)
        {
            return (2 * Math.PI * R);
        }
        static public double GetSquare(double R)
        {
            return (Math.PI * Math.Pow(R, 2));
        }
        int x, y;
    }
    class Point
    {
        int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static bool CheckPoint(Point center, int rad, Point point)
        {
            return (Math.Sqrt(Math.Pow(point.x - center.x, 2) + Math.Pow(point.y - center.y, 2)) <= rad);
        }
    }
}

