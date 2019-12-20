//1. Пользователь вводит два числа.Вывести на экран большее
using System;

namespace Task01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter 2 numbers");
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			if (a > b)
				Console.WriteLine($"\n{a}");
			else
				if (a < b)
				Console.WriteLine(b);
			else
				Console.WriteLine("Numbers are equal");
			Console.ReadKey();
		}
	}
}
