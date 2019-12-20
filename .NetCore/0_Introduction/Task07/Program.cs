//7. Дано натуральное число. Выяснить, является ли оно простым,
//т.е. делится только на 1 и на само себя.
using System;

namespace Task07
{
	class Program
	{
		static void Main(string[] args)
		{
			bool prime = true;
			Random rand = new Random();
			int n = rand.Next(100);
			Console.WriteLine(n);
			int i = 2;
			for (; i <= n / 2; i++)
			{
				if (n % i == 0)
				{
					prime = false;
					break;
				}
			}
			if (prime)
				Console.WriteLine("Number is prime");
			else
				Console.WriteLine("Number is not prime");
			Console.ReadKey();
		}
	}
}
