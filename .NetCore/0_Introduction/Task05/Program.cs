//5. Вывести название дня недели по его номеру(1 - понедельник, 7 - воскресенье)
using System;

namespace Task05
{
	class Program
	{
		static void Main(string[] args)
		{
			int weekday;
			while (true)
			{
				Console.WriteLine("Enter weekday number:");
				weekday = int.Parse(Console.ReadLine());
				if (weekday < 1 | weekday > 7)
				{
					Console.WriteLine("Incorrect number");
					continue;
				}
				break;
			}
			switch (weekday)
			{
				case 1:
					Console.WriteLine("Monday");
					break;
				case 2:
					Console.WriteLine("Tuesday");
					break;
				case 3:
					Console.WriteLine("Wednesday");
					break;
				case 4:
					Console.WriteLine("Thursday");
					break;
				case 5:
					Console.WriteLine("Friday");
					break;
				case 6:
					Console.WriteLine("Saturday");
					break;
				case 7:
					Console.WriteLine("Sunday");
					break;
			}
			Console.ReadKey();
		}
	}
}
