using System;
using System.Collections.Generic;
using System.Text;

namespace Task6
{
	class Converter
	{
		double usd;
		double eur;
		double rub;

		public Converter(double usd, double eur, double rub)
		{
			this.usd = usd;
			this.eur = eur;
			this.rub = rub;
		}

		public void ConvertUSDtoUAH(double usd)
		{
			Console.WriteLine($"{usd} USD = {usd * this.usd} UAH");
		}

		public void ConvertEURtoUAH(double eur)
		{
			Console.WriteLine($"{eur} EUR = {eur * this.eur} UAH");
		}

		public void ConvertRUBtoUAH(double rub)
		{
			Console.WriteLine($"{rub} RUB = {rub * this.rub} UAH");
		}

		public void ConvertToUSD(double uah)
		{
			Console.WriteLine($"{uah} UAH = {uah / this.usd} USD");
		}

		public void ConvertToEUR(double uah)
		{
			Console.WriteLine($"{uah} UAH = {uah / this.eur} EUR");
		}

		public void ConvertToRUB(double uah)
		{
			Console.WriteLine($"{uah} UAH = {uah / this.rub} RUB");
		}
	}
}
