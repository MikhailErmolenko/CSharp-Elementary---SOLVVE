using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
	class Author
	{
		string author;

		void Show()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Author: {author}");
		}
	}
}
