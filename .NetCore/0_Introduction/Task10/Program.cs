//10. Вывести на экран таблицу умножения на N от 1 до 20 где N число
//введенное пользователем 2. Пользователь вводит число вывести на
//экран количество разрядов в этом числе
using System;

namespace Task10
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the number:");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine("\n");
			for (int i = 1; i <= 20; i++)
				Console.WriteLine($"{n * i}");
			n = Math.Abs(n);
			string str = Convert.ToString(n);
			Console.WriteLine($"\nNumber of digits: {str.Length}");
			Console.ReadKey();
		}
	}
}
