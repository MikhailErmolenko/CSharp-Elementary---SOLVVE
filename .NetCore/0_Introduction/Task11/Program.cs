//11. Программа загадывает число от 1 до 146. Пользователь пытается его угадать.
//В случае неверного ответа программа дает подсказку «больше» или «меньше»
using System;

namespace Task11
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			int n = rnd.Next(1, 147);
			int n1 = 0;
			while (n1 != n)
			{
				Console.WriteLine("Guess the number(1-146):");
				n1 = int.Parse(Console.ReadLine());
				if (n1 == n)
					Console.WriteLine("Correct");
				else
					if (n1 < n)
					Console.WriteLine("More");
				else
					Console.WriteLine("Less");
			}
			Console.ReadKey();
		}
	}
}
