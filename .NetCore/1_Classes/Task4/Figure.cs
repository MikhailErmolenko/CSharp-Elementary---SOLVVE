using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
	class Figure
	{
		List<Point> points = new List<Point>();
		private string name;

		public Figure(string name, Point A, Point B, Point C)
		{
			this.name = name;
			points.Add(A);
			points.Add(B);
			points.Add(C);
		}

		public Figure (string name, Point A, Point B, Point C, Point D) : this (name, A, B, C)
		{
			points.Add(D);
		}

		public Figure (string name, Point A, Point B, Point C, Point D, Point E) : this(name, A, B, C, D)
		{
			points.Add(E);
		}
		double LengthSide(Point a, Point b)
		{
			return Math.Sqrt(Math.Pow(b.x - a.x, 2)+Math.Pow(b.y - a.y,2));
		}

		public void PerimeterCalculator()
		{
			double Perimeter = 0;
			for (int i= 0; i<points.Count - 1; i++)
			{
				Perimeter += LengthSide(points[i], points[i+1]);
			}
			Perimeter += LengthSide(points[points.Count - 1], points[0]);
			Console.WriteLine($"Perimeter = {Perimeter}");
		}

		public void ShowName()
		{
			Console.WriteLine($"This is {name}");
		}
	}
}
