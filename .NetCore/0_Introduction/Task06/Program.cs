//6. Служба такси заказала вам программу, которая спрашивает количество
//километров и количество минут простоя, а дальше считает так: первые
//5 километров(или до 5 км) 20 гривен, каждый следующий километр 3
//гривны, плюс простой 1 грн за 1 минуту.Программа должна посчитать
//и сказать общую сумму оплаты за поездку.
using System;

namespace Task06
{
	class Program
	{
		static void Main(string[] args)
		{
			int d, t, s;
			Console.WriteLine("Enter distance:");
			d = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter waiting time:");
			t = int.Parse(Console.ReadLine());
			if (d <= 5)
				s = d * 20 + t;
			else
				s = 100 + (d - 5) * 3 + t;
			Console.WriteLine();
			Console.WriteLine($"Payment amount:{s}");
			Console.ReadKey();
		}
	}
}
