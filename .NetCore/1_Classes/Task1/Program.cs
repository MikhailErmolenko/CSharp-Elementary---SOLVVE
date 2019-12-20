//Требуется:
//Создать класс с именем Address.
//В теле класса требуется создать поля: index, country, city, street, house, apartment.
//Для каждого поля, создать свойство с двумя методами доступа.
//Создать экземпляр класса Address.
//В поля экземпляра записать информацию о почтовом адресе.
//Выведите на экран значения полей, описывающих адрес.
using System;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			Address obj = new Address() { index = 21342, country = "Ukraine", city = "Dnipro", street = "Kazakova", house = "38", apartment = 702 };
			obj.AddressOutput();
			Console.ReadKey();
		}
	}
}
