//4. Пользователь вводит число 1 или 0 с помощью одной строки кода
//вывести на экран «Хорошо» если пользователь ввел 1 или «Плохо»
//если пользователь ввел 0
using System;

namespace Task04
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;
			while (true)
			{
				Console.WriteLine("Enter 1 or 0");
				a = int.Parse(Console.ReadLine());
				if (a != 0 && a != 1)
				{
					Console.WriteLine("Incorrect value");
					continue;
				}
				break;
			}
			if (a == 1)
				Console.WriteLine("Good");
			else
				Console.WriteLine("Bad");
			Console.ReadKey();
		}
	}
}
