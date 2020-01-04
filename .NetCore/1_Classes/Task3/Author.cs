using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
	class Author
	{
		public string author;

		 public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Author: {author}");
		}
	}
}
