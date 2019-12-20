//Требуется: Создать класс с именем Rectangle.
//В теле класса создать два поля, описывающие длины сторон double side1, side2.
//Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.
//Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().
//Создать два свойства double Area и double Perimeter с одним методом доступа get.
//Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.
using System;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
        {
            double s1 = GetUserInput("Enter first side size:");
            double s2 = GetUserInput("Enter second side size:");

            Rectangle rectangle = new Rectangle(s1, s2);
            Console.WriteLine(rectangle.ToString());
            Console.ReadKey();
        }

        public static double GetUserInput(string prompt)
        {
            double value;
            Console.WriteLine(prompt);
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out value))
                    break;
                else
                    Console.WriteLine("Incorrect value. Pls try again:");
            }
            return value;
        }
	}
}
