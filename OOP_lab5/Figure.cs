using System;

namespace lab6
{
	abstract class Figure
	{
		public Point GetPoint(int index)
		{
			Point err;
			err.x = 0;
			err.y = 0;
			if (index< _countSides && index >= 0)
			{
				return _cords[index];
			}
			else
            {
				return err;
            }
		}
        
		

		public bool Intersect(Figure figure1, Figure figure2)
		{
			double radius1 = GetRadius(figure1);
			double radius2 = GetRadius(figure2);

			Point center1 = figure1.CenterGravity();
			Point center2 = figure2.CenterGravity();
			double length = GetLength(center1, center2);

		if (length > radius1 + radius2 || length <= Math.Abs(radius1 - radius2))
		{
			return false;
		}

		return true;
		}

	public bool Include(Figure figure1, Figure figure2)
	{
		double radius1 = GetRadius(figure1);
		double radius2 = GetRadius(figure2);

		Point center1 = figure1.CenterGravity();
		Point center2 =figure2.CenterGravity();
		double length = GetLength(center1, center2);

		if (length <= Math.Abs(radius1 - radius2))
		{
			return true;
		}
		return false;
	}


	public double GetRadius(Figure figure)
	{
		double max = 0;
		Point center = figure.CenterGravity();
		for (int i = 0; i < figure._countSides; i++)
		{
			double lenght = GetLength(center, figure.GetPoint(i));
			if (max < lenght)
			{
				max = lenght;
			}
		}
		
		return max;
	}


		public string ToStringFigure()
		{
			string result = "";
			for (int i = 0; i < _countSides; i++)
			{
				result += Convert.ToString(i) + " - " + "( ";
				result += Convert.ToString(_cords[i].x);
				result += ", ";
				result += Convert.ToString(_cords[i].y);
				result += " )\n";

			}
			result += "Area: " + Convert.ToString(Area()) + "\n" + "Perimeter: " + Convert.ToString(Perimeter()) + "\nCenter gravity: x(" + Convert.ToString(CenterGravity().x) +") " + "y: (" + Convert.ToString(CenterGravity().y) + ")\n";
			return result;
		}
		public void Move(string route, int scale)
		{
			switch (route)
			{
				case "right":
					for (int i = 0; i < _countSides; i++)
					{
						_cords[i].x += scale;
					}
					break;
				case "left":
					for (int i = 0; i < _countSides; i++)
					{
						_cords[i].x -= scale;
					}
					break;
				case "down":
					for (int i = 0; i < _countSides; i++)
					{
						_cords[i].y -= scale;
					}
					break;
				case "up":
					for (int i = 0; i < _countSides; i++)
					{
						_cords[i].y += scale;
					}
					break;
			}
		}
		public double Perimeter()
		{
			double per = 0;
			for (int i = 1; i < _countSides; i++)
			{
				per += GetLength(_cords[i - 1 ], _cords[i]);
			}
			per += GetLength(_cords[_countSides - 1], _cords[0]);
			return per;
		}
		abstract public double Area();
		abstract public Point CenterGravity();

		public double GetLength(Point point1, Point point2)
		{
			double length = Math.Sqrt(Math.Abs(point1.x - point2.x) * Math.Abs(point1.x - point2.x) + Math.Abs(point1.y - point2.y) * Math.Abs(point1.y - point2.y));
			return length;
		}
		protected Point[] _cords;
		protected int _countSides = 0;
	}
}