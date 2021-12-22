using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Triangle : Figure
    {
        public Triangle(Point[] cords)
        {
            _countSides = 3;
            _cords = new Point[_countSides];

            for (int i = 0; i < _countSides; i++)
            {
                _cords[i].x = cords[i].x;
                _cords[i].y = cords[i].y;
            }
        }
        public override double Area()
        {
            double area;

            return area = AreaOfTriangle(_cords[0], _cords[1], _cords[2]);
        }
        public override Point CenterGravity()
        {
            Point centerGravity;

            return centerGravity = CenterOfTriangle(_cords[0], _cords[1], _cords[2]); ;
        }
        protected Point CenterOfTriangle(Point a, Point b, Point c)
        {
            Point result;
            result.x = (a.x + b.x + c.x) / 3;
            result.y = (a.y + b.y + c.y) / 3;
            return result;
        }
        protected double AreaOfTriangle(Point a, Point b, Point c)
        {
            return Math.Abs(0.5 * ((a.x - c.x) * (b.y - c.y) - (a.y - c.y) * (b.x - c.x)));
        }
    }
}
