using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
	class Invoice
	{
		readonly int account;
		readonly string customer;
		readonly string provider;

		string article;
		int quantity;

		bool wNDS;

		public Invoice (int account, string customer, string provider)
		{
			this.account = account;
			this.customer = customer;
			this.provider = provider;
		}

		public string CostCalculation(string article, int quantity, bool wNDS)
		{
			this.article = article;
			this.quantity = quantity;
			this.wNDS = wNDS;
			double nds = 1.2;
			int price = 0;

			switch (article)
			{
				case "computer":
					price = 1000;
					break;
				case "phone":
					price = 500;
					break;
			}

			if (wNDS)
				return $"Price with NDS:  {price * quantity * nds}";
			else
				return $"Price without NDS::  {price * quantity}";
		}

		public override string ToString()
		{
			return $"Customer:         {customer}\n" +
				   $"Provider:         {provider}\n" +
				   $"{CostCalculation(article, quantity, wNDS)}";
		}
	}
}
