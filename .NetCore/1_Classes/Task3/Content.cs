using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
	class Content
	{
		string content;
		void Show()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Content: {content}");
		}
	}
}
