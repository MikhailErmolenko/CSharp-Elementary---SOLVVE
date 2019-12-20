//12.Выведите все точные квадраты натуральных чисел,
//которые (квадраты) меньше заданного числа N.
using System;

namespace Task12
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			Console.WriteLine("Enter the number:");
			while (true)
			{
				if (!int.TryParse(Console.ReadLine(), out n))
				{
					Console.WriteLine("Incorrect number. Try again:");
					continue;
				}
				else
					break;
			}
			Console.WriteLine("");
			for (int i = 1; i * i < n; i++)
				Console.WriteLine(i * i);
			Console.ReadKey();
		}
	}
}
