//Требуется:
//Создать классы Point и Figure.
//Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
//Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника;
//void PerimeterCalculator(), который рассчитывает периметр многоугольника.
//Написать программу, которая выводит на экран название и периметр многоугольника.
using System;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			Point A = new Point(0, 1, "A");
			Point B = new Point(2, 3, "B");
			Point C = new Point(4, 5, "C");
			Point D = new Point(6, 7, "D");

			Figure figure = new Figure("Rectangle", A, B, C, D);
			figure.ShowName();
			figure.PerimeterCalculator();
			Console.ReadKey();
		}
	}
}
