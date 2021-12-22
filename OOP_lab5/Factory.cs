using System;


namespace lab6
{
    class Factory
    {
        public Figure createFigure(Point[] cords, int count)
        {

            if (count == 4)
                return new Trapezoid(cords);
            else
                return new Triangle(cords);
        }
    }
}
