//3. Пользователь вводит номер месяца если месяц 1,2,12 вывести на экран «Зима»; 3,4,5 – «Весна»; 6-8 – «Лето»; 9-11 – «Осень».
//В любом другом случае «На этой планете такого месяца нет»
using System;

namespace Task03
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter number of months:");
			int month = int.Parse(Console.ReadLine());
			switch (month)
			{
				case 12:
				case 1:
				case 2:
					Console.WriteLine("Winter");
					break;
				case 3:
				case 4:
				case 5:
					Console.WriteLine("Spring");
					break;
				case 6:
				case 7:
				case 8:
					Console.WriteLine("Summer");
					break;
				case 9:
				case 10:
				case 11:
					Console.WriteLine("Fall");
					break;
				default:
					Console.WriteLine("There is no such month on this planet");
					break;
			}
			Console.ReadKey();
		}
	}
}
