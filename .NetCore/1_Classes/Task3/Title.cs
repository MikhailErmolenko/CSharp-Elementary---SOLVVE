using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
	class Title
	{
		string title;

		void Show()
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"Title: {title}");
			}
	}
}
