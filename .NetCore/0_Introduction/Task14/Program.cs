//14.Создать 5 случайных целых чисел, подсчитать их среднее
//арифметическое и сообщить его пользователю
using System;

namespace Task14
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int sum = 0;
			for (int i = 0; i < 5; i++)
			{
				int n = rnd.Next(100);
				Console.WriteLine(n);
				sum += n;
			}
			Console.WriteLine($"Average value:\n{sum / 5}");
			Console.ReadKey();
		}
	}
}
