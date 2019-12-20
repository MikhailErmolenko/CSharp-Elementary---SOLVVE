//8. Вы организатор лотереи.Пользователь вводит ставку. Вы бросаете
//12-гранный кубик. Если выпадают значения от 1 до 5, пользователь
//проиграл. Если выпадают значения от 6 до 8, пользователь получает
//свою ставку обратно. Если выпало от 9 до 11, пользователь получает
//двойную ставку, а если выпало 12 - ставку умноженную на 10. После
//окончания игры покажите пользователю, сколько он выиграл.
using System;

namespace Task08
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();
			Console.WriteLine("Your bet:");
			int bet = int.Parse(Console.ReadLine());
			int n = rand.Next(1, 13);
			Console.WriteLine($"Dropped value: {n}");
			switch (n)
			{
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
					bet = 0;
					break;
				case 9:
				case 10:
				case 11:
					bet = bet * 2;
					break;
				case 12:
					bet = bet * 10;
					break;
			}
			Console.WriteLine($"Your winning: {bet}");
			Console.ReadKey();
		}
	}
}
