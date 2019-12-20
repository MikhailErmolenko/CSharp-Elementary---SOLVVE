//13. Прочитать с клавиатуры 5 целых чисел, подсчитать их среднее
//арифметическое и сообщить его пользователю
using System;

namespace Task13
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = new int[5];
			double sum = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				Console.WriteLine($"Enter the {i + 1} number:");
				while (true)
				{
					if (int.TryParse(Console.ReadLine(), out nums[i]))
						break;
					else
					{
						Console.WriteLine("Incorrect number. Try again:");
						continue;
					}
				}
			}
			foreach (int i in nums)
			{
				sum += i;
			}
			Console.WriteLine($"Average value:\n{sum / 5}");
			Console.ReadKey();
		}
	}
}
