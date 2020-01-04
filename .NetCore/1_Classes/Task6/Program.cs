//Требуется:
//Создать класс Converter.
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
//и инициализирует поля соответствующие курсу 3-х основных валют,
//по отношению к гривне - public Converter(double usd, double eur, double rub).
//Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
//также программа должна производить конвертацию из указанных валют в гривну.
using System;

namespace Task6
{
	class Program
	{
		static void Main(string[] args)
		{
			Converter converter = new Converter(24.45, 27.15, 0.37);
			converter.ConvertUSDtoUAH(123.45);
			converter.ConvertEURtoUAH(123.45);
			converter.ConvertRUBtoUAH(123.45);
			converter.ConvertToUSD(123.45);
			converter.ConvertToEUR(123.45);
			converter.ConvertToRUB(123.45);
			Console.ReadKey(); 
		}
	}
}
