//Требуется:
//Создать класс User, содержащий информацию о пользователе(логин, имя, фамилия, возраст, дата заполнения анкеты).
//Поле дата заполнения анкеты должно быть проинициализировано только один раз(при создании экземпляра данного класса)
//без возможности его дальнейшего изменения.
//Реализуйте вывод на экран информации о пользователе.
using System;

namespace Task5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Create a login: ");
			string login = Console.ReadLine();

			Console.WriteLine("Enter your name: ");
			string name = Console.ReadLine();

			Console.WriteLine("Enter your surname: ");
			string surname = Console.ReadLine();

			Console.WriteLine("Enter your age: ");
			int age;

			while (!int.TryParse(Console.ReadLine(), out age))
			{
				Console.WriteLine("Incorrect value. Pls try again:");
			}

			User Maykl = new User(login, name, surname, age, DateTime.Now);
			Console.WriteLine(Maykl.ToString()); 

			Console.ReadKey();
		}
	}
}
