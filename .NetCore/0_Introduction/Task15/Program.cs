//15. У гусей и кроликов вместе 64 лапы.
//Сколько может быть кроликов и гусей(указать все сочетания)?
using System;

namespace Task15
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 16; i++)
			{
				for (int j = 1; j <= 32; j++)
				{
					if (i * 4 + j * 2 == 64)
						Console.WriteLine($"{i} Rabits and {j} Gesse");
				}
			}
			Console.ReadKey();
		}
	}
}
