using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab6
{
    class Trapezoid : Figure
    {
        public Trapezoid(Point[] cords)
        {
            _countSides = 4;
            _cords = new Point[_countSides];

            for(int i=0;i<_countSides;i++)
            {
                _cords[i].x = cords[i].x;
                _cords[i].y = cords[i].y;
            }
        }
       public override double Area()
        {
            double h = GetH();
            return (GetLength(_cords[0], _cords[1]) + GetLength(_cords[3], _cords[0]))/2*h;
        }

        public double GetH()
        {

            double c = GetLength(_cords[0], _cords[1]);
            double a = GetLength(_cords[1], _cords[2]);
            double d = GetLength(_cords[2], _cords[3]);
            double b = GetLength(_cords[3], _cords[0]);
            return Math.Sqrt(c * c - ((Math.Pow(b - a, 2) + c * c - d * d) / (2 * (b - a))));
        }


        public override Point CenterGravity()
        {
            Point centerGravity;

            double centerTriangleX1 = (_cords[0].x + _cords[1].x + _cords[2].x) / 3;
            double centerTriangleY1 = (_cords[0].y + _cords[1].y + _cords[2].y) / 3;
            double centerTriangleX2 = (_cords[2].x + _cords[3].x + _cords[0].x) / 3;
            double centerTriangleY2 = (_cords[2].y + _cords[3].y + _cords[0].y) / 3;

            double areaTriangle1 = AreaOfTriangle(_cords[0], _cords[1], _cords[2]);
            double areaTriangle2 = AreaOfTriangle(_cords[2], _cords[3], _cords[0]);

            centerGravity.x = (areaTriangle1 * centerTriangleX1 + areaTriangle2 * centerTriangleX2) / (areaTriangle1 + areaTriangle2);
            centerGravity.y = (areaTriangle1 * centerTriangleY1 + areaTriangle2 * centerTriangleY2) / (areaTriangle1 + areaTriangle2);

            return centerGravity;
        }

        protected double AreaOfTriangle(Point a, Point b, Point c)
        {
            return Math.Abs(0.5 * ((a.x - c.x) * (b.y - c.y) - (a.y - c.y) * (b.x - c.x)));
        }
    }
}
