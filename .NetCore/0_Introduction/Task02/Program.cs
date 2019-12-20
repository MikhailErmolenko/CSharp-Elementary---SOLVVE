//2. Пользователь вводит слово «мяу» или слово «гав» если слово
//введенное пользователем «мяу» вывести на экран «Покорми кота»
//иначе «Погуляй с собакой»
using System;

namespace Task02
{
	class Program
	{
		static void Main(string[] args)
		{
			string sound;
			while (true)
			{
				Console.WriteLine("`myayu` or `gav`");
				sound = Console.ReadLine();
				if (sound != "myayu" && sound != "gav")
				{
					Console.WriteLine("Incorrect value");
					continue;
				}
				break;
			}
			switch (sound)
			{
				case "myayu":
					Console.WriteLine("Feed the cat");
					break;
				case "gav":
					Console.WriteLine("Walk with the dog");
					break;
				default:
					Console.WriteLine("Not right");
					break;
			}
			Console.ReadKey();
		}
	}
}
