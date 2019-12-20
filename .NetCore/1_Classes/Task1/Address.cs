using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
	class Address
	{
		public int index { get; set; }
		public string country { get; set; }
		public string city { get; set; }
		public string street { get; set; }
		public string house { get; set; }
		public int apartment { get; set; }
		public void AddressOutput()
		{
			Console.WriteLine($"Index: {index}\n" +
							  $"Country: {country}\n" +
							  $"City: {city}\n" +
							  $"Street: {street}\n" +
							  $"House: {house}\n" +
							  $"Apartment: {apartment}\n");
		}
	}
}
