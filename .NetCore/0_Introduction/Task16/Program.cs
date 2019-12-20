//16. Напишите программу, которая будет «спрашивать» правильный пароль, до тех пор,
//пока он не будет введен. Правильный пароль пусть будет «root».
//Если пароль не верный, программа должна сказать "Неверный пароль!"
using System;

namespace Task16
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter password:");
			while (Console.ReadLine() != "root")
			{
				Console.WriteLine("Incorrect password! Try again:");
				continue;
			}
			Console.WriteLine("Access granted!");
			Console.ReadKey();		
		}
	}
}
