using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
	class Title
	{
		public string title;

		public void Show()
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"\nTitle: {title}");
			}
	}
}
