//9. Сделать программу перевода валют. Вводится сумма, потом
//выбирается вид валюты – гривны или доллары или евро, программа
//переводит в две другие валюты. Текущий курс валюты считать известным.
using System;

namespace Task09
{
	class Program
	{
		static void Main(string[] args)
		{
			int curr;
			Console.WriteLine("Enter the amount:");
			int sum = int.Parse(Console.ReadLine());
			while (true)
			{
				Console.WriteLine("\nChoose currency:\n " +
								  "Grivna(1)\n " +
								  "Dollars(2)\n " +
								  "Euro(3)\n");
				curr = int.Parse(Console.ReadLine());
				if (curr < 1 | curr > 3)
				{
					Console.WriteLine("Incorrect value");
					continue;
				}
				break;
			}
			float gd = 23.5f;
			float ge = 26;
			float de = 0.9f;
			switch (curr)
			{
				case 1:
					Console.WriteLine($"\nDollars - {Math.Round(sum / gd, 2)};\n" +
									  $"Euro - {Math.Round(sum / ge, 2)};");
					break;
				case 2:
					Console.WriteLine($"\nGrivna - {Math.Round(sum * gd, 2)};\n" +
									  $"Euro - {Math.Round(sum * de, 2)};");
					break;
				case 3:
					Console.WriteLine($"\nGrivna - {Math.Round(sum * ge, 2)};\n" +
									  $"Dollars - {Math.Round(sum / de, 2)};");
					break;
			}
			Console.ReadKey();
		}
	}
}
