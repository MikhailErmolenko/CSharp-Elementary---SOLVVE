//Требуется:
//Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().
//Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
//Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
using System;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			Title newtitle = new Title();
			Console.WriteLine("Enter title of book:");
			newtitle.title = Console.ReadLine();

			Author newauthor = new Author();
			Console.WriteLine("Enter author name:");
			newauthor.author = Console.ReadLine();

			Content newcontent = new Content();
			Console.WriteLine("Tell me about this book:");
			newcontent.content = Console.ReadLine();

			Book book = new Book(newtitle, newauthor, newcontent);
			book.Show();
			Console.ReadKey();
		}
	}
}
